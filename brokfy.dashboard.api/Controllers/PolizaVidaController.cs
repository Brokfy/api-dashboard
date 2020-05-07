using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using brokfy.dashboard.api.data.DataModel;
using Microsoft.Extensions.Configuration;
using brokfy.dashboard.api.Models;
using System;
using brokfy.dashboard.api.data.ViewModel;

namespace brokfy.dashboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaVidaController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public PolizaVidaController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Polizas/
        [HttpGet]
        public List<PolizaVida> GetPolizaVida([FromQuery] string propia)
        {
            var result = from p in _context.Polizas
                         join v in _context.Vida on p.NoPoliza equals v.NoPoliza
                         where p.PolizaPropia == propia
                         select new PolizaVida
                         {
                             NoPoliza = p.NoPoliza,
                             FormaPago = p.FormaPago,
                             ProximoPago = p.ProximoPago,
                             FechaInicio = p.FechaInicio,
                             FechaFin = p.FechaFin,
                             IdAseguradoras = p.IdAseguradoras,
                             Costo = p.Costo,
                             Username = p.Username,
                             ProductoId = p.ProductoId,
                             Habilitada = p.Habilitada,
                             NoAsegurado = p.NoAsegurado,
                             PolizaPropia = p.PolizaPropia,
                             PolizaPdf = p.PolizaPdf,
                             //ReciboPdf = p.ReciboPdf,
                             RcUsaCanada = p.RcUsaCanada,
                             CostoPrimerRecibo = p.CostoPrimerRecibo,
                             CostoRecibosSubsecuentes = p.CostoRecibosSubsecuentes,
                             Fumador = v.Fumador,
                             Estatura = v.Estatura,
                             Peso = v.Peso,
                             Ingresos = v.Ingresos,
                             IdOcupacion = v.IdOcupacion,
                             IdEstadoCivil = v.IdEstadoCivil,
                             IdSexo = v.IdSexo
                         };

            return result.ToList();
        }

        // GET: api/Polizas/5
        [HttpGet("{id}")]
        public List<PolizaVida> GetPolizaVidaDetalle(string id)
        {
            var result = from p in _context.Polizas
                         join v in _context.Vida on p.NoPoliza equals v.NoPoliza
                         where p.NoPoliza == id
                         select new PolizaVida
                         {
                             NoPoliza = p.NoPoliza,
                             FormaPago = p.FormaPago,
                             ProximoPago = p.ProximoPago,
                             FechaInicio = p.FechaInicio,
                             FechaFin = p.FechaFin,
                             IdAseguradoras = p.IdAseguradoras,
                             Costo = p.Costo,
                             Username = p.Username,
                             ProductoId = p.ProductoId,
                             Habilitada = p.Habilitada,
                             NoAsegurado = p.NoAsegurado,
                             PolizaPropia = p.PolizaPropia,
                             PolizaPdf = p.PolizaPdf,
                             //ReciboPdf = p.ReciboPdf,
                             RcUsaCanada = p.RcUsaCanada,
                             CostoPrimerRecibo = p.CostoPrimerRecibo,
                             CostoRecibosSubsecuentes = p.CostoRecibosSubsecuentes,
                             Fumador = v.Fumador,
                             Estatura = v.Estatura,
                             Peso = v.Peso,
                             Ingresos = v.Ingresos,
                             IdOcupacion = v.IdOcupacion,
                             IdEstadoCivil = v.IdEstadoCivil,
                             IdSexo = v.IdSexo
                         };

            return result.ToList();
        }
        // PUT: api/Polizas/5
        [HttpPut]
        public ResponseModel PutPolizaVida([FromBody] PolizaVida data)
        {
            try
            {
                Polizas poliza = new Polizas()
                {
                    TipoPoliza = 5,
                    NoPoliza = data.NoPoliza,
                    FormaPago = data.FormaPago,
                    ProximoPago = data.ProximoPago,
                    FechaInicio = data.FechaInicio,
                    FechaFin = data.FechaFin,
                    IdAseguradoras = data.IdAseguradoras,
                    Costo = data.Costo,
                    Username = data.Username,
                    ProductoId = data.ProductoId,
                    Habilitada = data.Habilitada,
                    NoAsegurado = data.NoAsegurado,
                    PolizaPropia = data.PolizaPropia,
                    PolizaPdf = data.PolizaPdf,
                    //ReciboPdf = data.ReciboPdf,
                    RcUsaCanada = data.RcUsaCanada,
                    CostoPrimerRecibo = data.CostoPrimerRecibo,
                    CostoRecibosSubsecuentes = data.CostoRecibosSubsecuentes
                };
                _context.Polizas.Update(poliza);

                Vida vida = new Vida()
                {
                    Fumador = data.Fumador,
                    Estatura = data.Estatura,
                    Peso = data.Peso,
                    Ingresos = data.Ingresos,
                    IdOcupacion = data.IdOcupacion,
                    IdEstadoCivil = data.IdEstadoCivil,
                    IdSexo = data.IdSexo,
                    NoPoliza = data.NoPoliza
                };
                _context.Vida.Update(vida);

                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/Polizas
        [HttpPost]
        public ResponseModel PostPolizaVida([FromBody] PolizaVida data)
        {
            try
            {
                Polizas poliza = new Polizas()
                {
                    TipoPoliza = 5,
                    NoPoliza = data.NoPoliza,
                    FormaPago = data.FormaPago,
                    ProximoPago = data.ProximoPago,
                    FechaInicio = data.FechaInicio,
                    FechaFin = data.FechaFin,
                    IdAseguradoras = data.IdAseguradoras,
                    Costo = data.Costo,
                    Username = data.Username,
                    ProductoId = data.ProductoId,
                    Habilitada = data.Habilitada,
                    NoAsegurado = data.NoAsegurado,
                    PolizaPropia = data.PolizaPropia,
                    PolizaPdf = data.PolizaPdf,
                    //ReciboPdf = data.ReciboPdf,
                    RcUsaCanada = data.RcUsaCanada,
                    CostoPrimerRecibo = data.CostoPrimerRecibo,
                    CostoRecibosSubsecuentes = data.CostoRecibosSubsecuentes
                };
                _context.Polizas.Add(poliza);

                Vida vida = new Vida()
                {
                    Fumador = data.Fumador,
                    Estatura = data.Estatura,
                    Peso = data.Peso,
                    Ingresos = data.Ingresos,
                    IdOcupacion = data.IdOcupacion,
                    IdEstadoCivil = data.IdEstadoCivil,
                    IdSexo = data.IdSexo,
                    NoPoliza = data.NoPoliza
                };
                _context.Vida.Add(vida);

                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }

        }

        // DELETE: api/Polizas/
        [HttpDelete]
        public ResponseModel DeletePolizaVida([FromBody] List<PolizaVida> data)
        {
            try
            {
                foreach (var item in data)
                {
                    _context.Vida.Remove(_context.Vida.Where(x => x.NoPoliza == item.NoPoliza).FirstOrDefault());
                    _context.Polizas.Remove(_context.Polizas.Where(x => x.NoPoliza == item.NoPoliza).FirstOrDefault());
                }

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