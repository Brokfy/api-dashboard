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
                                               join prof in _context.Profesiones on pf.IdProfesion equals prof.Id
                                               where pf.IdPerfil == username
                                               select new PerfilAseguradoModel
                                               {
                                                   IdPerfil = pf.IdPerfil,
                                                   Municipio = pf.Municipio,
                                                   CodigoPostal = pf.CodigoPostal,
                                                   Estado = pf.Estado,
                                                   Hijos = pf.Hijos,
                                                   Edad = pf.Edad,
                                                   RegimenVivienda = pf.RegimenVivienda,
                                                   SituacionLaboral = pf.SituacionLaboral,
                                                   Hipoteca = pf.Hipoteca,
                                                   Viaja = pf.Viaja,
                                                   Mascotas = pf.Mascotas,
                                                   EstadoCivil = pf.EstadoCivil,
                                                   Profesion = prof.Descripcion,
                                                   //DetallePerfilAsegurado = new DetallePerfilAsegurado()
                                                   //{
                                                   //    Actividades = (from act in _context.PerfilAseguradoToActividades
                                                   //                   where act.IdPerfil == username
                                                   //                   select act).ToList()
                                                   //}
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

            DetallePerfilAsegurado detallePerfil = new DetallePerfilAsegurado()
            {
                Actividades = (from pAct in _context.PerfilAseguradoToActividades 
                               join act in _context.Actividades on pAct.IdActividad equals act.Id
                               select act).ToList(),
                Gadgets = (from pGad in _context.PerfilAseguradoTieneGadgets
                           join gad in _context.Gadgets on pGad.IdGadgets equals gad.Id
                           select gad).ToList(),
                Propiedades = (from pProp in _context.PerfilAseguradoToPropiedades
                               join prop in _context.Propiedades on pProp.IdPropiedades equals prop.Id
                               select prop).ToList(),
                Salud = (from pSal in _context.PerfilAseguradoToSalud
                         join sal in _context.Salud on pSal.IdSalud equals sal.Id
                         select sal).ToList()
            };


            return new DetalleCliente() { 
                DatosPersonales = perfil,
                PerfilAsegurado = perfilAsegurado,
                Polizas = polizas,
                DetallePerfil = detallePerfil
            };
        }
    }
}