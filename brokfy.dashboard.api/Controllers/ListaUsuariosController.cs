using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using brokfy.dashboard.api.data.DataModel;
using Microsoft.Extensions.Configuration;
using System;
using brokfy.dashboard.api.data.ViewModel;
using Newtonsoft.Json;
using brokfy.dashboard.api.Models;

namespace brokfy.dashboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaUsuariosController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public ListaUsuariosController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/ListaUsuarios
        [HttpGet]
        public List<Perfil> GetListaUsuarios()
        {
            var result = _context.Perfil.ToList();
            return result.ToList();
        }

        //GET: api/ListaUsuarios/554654516
        [HttpGet("{username}")]
        public DetalleCliente GetListaUsuarios(string username)
        {

            Perfil perfil = _context.Perfil.Where(x => x.Username == username).FirstOrDefault();
            PerfilAseguradoModel perfilAsegurado = (from pf in _context.PerfilAsegurado
                                                   // join prof in _context.Profesiones on pf.IdProfesion equals prof.Id
                                                    where pf.IdPerfil == username
                                                    select new PerfilAseguradoModel
                                                    {
                                                        IdPerfil = pf.IdPerfil,
                                                        //Municipio = pf.Municipio,
                                                        //CodigoPostal = pf.CodigoPostal,
                                                        //Estado = pf.Estado,
                                                        Hijos = pf.Hijos,
                                                        //Edad = pf.Edad,
                                                        RegimenVivienda = pf.RegimenVivienda,
                                                        //SituacionLaboral = pf.SituacionLaboral,
                                                        //Hipoteca = pf.Hipoteca,
                                                        Viaja = pf.Viaja,
                                                        //Mascotas = pf.Mascotas,
                                                        EstadoCivil = pf.EstadoCivil,
                                                        //Profesion = prof.Descripcion,
                                                    }).FirstOrDefault();
            List<PolizasModel> polizas = (from pol in _context.Polizas
                                          join tp in _context.TipoPoliza on pol.TipoPoliza equals tp.Id
                                          join aseg in _context.Aseguradoras on pol.IdAseguradoras equals aseg.IdAseguradora
                                          join prod in _context.Productos on pol.ProductoId equals prod.Id
                                          join edo in _context.EstadosPolizas on pol.IdEstadoPoliza equals edo.Id
                                          where pol.Username == username
                                          select new PolizasModel {
                                              TipoPoliza = tp.Tipo,
                                              Costo = pol.Costo,
                                              NoPoliza = pol.NoPoliza,
                                              FormaPago = pol.FormaPago,
                                              ProximoPago = pol.ProximoPago,
                                              FechaInicio = pol.FechaInicio,
                                              FechaFin = pol.FechaFin,
                                              Aseguradora = aseg.Nombre,
                                              Username = pol.Username,
                                              Producto = prod.Producto,
                                              Habilitada = pol.Habilitada,
                                              NoAsegurado = pol.NoAsegurado,
                                              PolizaPropia = pol.PolizaPropia,
                                              CostoPrimerRecibo = pol.CostoPrimerRecibo,
                                              CostoRecibosSubsecuentes = pol.CostoRecibosSubsecuentes,
                                              PrimaNeta = pol.PrimaNeta,
                                              EstadoPoliza = edo.Nombre
                                          }).ToList();

            /*IQueryable<PerfilAseguradoToActividades> preAct = from pre in _context.PerfilAseguradoToActividades where pre.IdPerfil == username select pre;
            IQueryable<PerfilAseguradoTieneGadgets> preGad = from pre in _context.PerfilAseguradoTieneGadgets where pre.IdPerfil == username select pre;
            IQueryable<PerfilAseguradoToPropiedades> preProp = from pre in _context.PerfilAseguradoToPropiedades where pre.IdPerfil == username select pre;
            IQueryable<PerfilAseguradoToSalud> preSal = from pre in _context.PerfilAseguradoToSalud where pre.IdPerfil == username select pre;*/


            DetallePerfilAsegurado detallePerfil = new DetallePerfilAsegurado()
            {
                /*Actividades = (from act in _context.Actividades
                               join pAct in preAct on act.Id equals pAct.IdActividad into ps
                               from pAct in ps.DefaultIfEmpty()
                               select new DescripcionValor
                               {
                                   Id = act.Id,
                                   Descripcion = act.Descripcion,
                                   Aplica = pAct != null
                               }).ToList(),
                Gadgets = (from gad in _context.Gadgets
                           join pGad in preGad on gad.Id equals pGad.IdGadgets into ps
                           from pGad in ps.DefaultIfEmpty()
                           select new DescripcionValor
                           {
                               Id = gad.Id,
                               Descripcion = gad.Descripcion,
                               Aplica = pGad != null
                           }).ToList(),
                Propiedades = (from prop in _context.Propiedades
                               join pProp in preProp on prop.Id equals pProp.IdPropiedades into ps
                               from pProp in ps.DefaultIfEmpty()
                               select new DescripcionValor
                               {
                                   Id = prop.Id,
                                   Descripcion = prop.Descripcion,
                                   Aplica = pProp != null
                               }).ToList(),
                Salud = (from sal in _context.Salud
                         join pSal in preSal on sal.Id equals pSal.IdSalud into ps
                         from pSal in ps.DefaultIfEmpty()
                         select new DescripcionValor
                         {
                             Id = sal.Id,
                             Descripcion = sal.Descripcion,
                             Aplica = pSal != null
                         }).ToList(),*/
            };


            return new DetalleCliente() {
                DatosPersonales = perfil,
                PerfilAsegurado = perfilAsegurado,
                Polizas = polizas,
                DetallePerfil = detallePerfil
            };
        }
    
        [HttpPost]
        public ResponseModel PostListaUsuarios([FromBody] PostDetallePerfilAseguradoModel data)
        {
            try
            {
                /*switch (data.Modulo)
                {
                    case "actividades":
                        if (data.Aplica)
                            _context.PerfilAseguradoToActividades.Add(new PerfilAseguradoToActividades { IdActividad = data.IdDetalle, IdPerfil = data.Username });
                        else
                            _context.PerfilAseguradoToActividades.Remove(_context.PerfilAseguradoToActividades.Where(x => x.IdActividad == data.IdDetalle && x.IdPerfil == data.Username).FirstOrDefault());
                        break;

                    case "gadgets":
                        if (data.Aplica)
                            _context.PerfilAseguradoTieneGadgets.Add(new PerfilAseguradoTieneGadgets { IdGadgets = data.IdDetalle, IdPerfil = data.Username });
                        else
                            _context.PerfilAseguradoTieneGadgets.Remove(_context.PerfilAseguradoTieneGadgets.Where(x => x.IdGadgets == data.IdDetalle && x.IdPerfil == data.Username).FirstOrDefault());
                        break;

                    case "propiedades":
                        if (data.Aplica)
                            _context.PerfilAseguradoToPropiedades.Add(new PerfilAseguradoToPropiedades { IdPropiedades = data.IdDetalle, IdPerfil = data.Username });
                        else
                            _context.PerfilAseguradoToPropiedades.Remove(_context.PerfilAseguradoToPropiedades.Where(x => x.IdPropiedades == data.IdDetalle && x.IdPerfil == data.Username).FirstOrDefault());
                        break;

                    case "salud":
                        if (data.Aplica)
                            _context.PerfilAseguradoToSalud.Add(new PerfilAseguradoToSalud { IdSalud = data.IdDetalle, IdPerfil = data.Username });
                        else
                            _context.PerfilAseguradoToSalud.Remove(_context.PerfilAseguradoToSalud.Where(x => x.IdSalud == data.IdDetalle && x.IdPerfil == data.Username).FirstOrDefault());
                        break;

                    default:
                        break;
                }*/

                _context.SaveChanges();

                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }
    }
}