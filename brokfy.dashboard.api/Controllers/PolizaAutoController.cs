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
using Newtonsoft.Json;

namespace brokfy.dashboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaAutoController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public PolizaAutoController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Polizas/
        [HttpGet]
        public List<PolizaAuto> GetPolizaAuto([FromQuery] string propia)
        {
            var result = from p in _context.Polizas
                         join a in _context.Auto on p.NoPoliza equals a.NoPoliza
                         where p.PolizaPropia == propia
                         select new PolizaAuto
                         {
                             NoPoliza = p.NoPoliza,
                             FormaPago = p.FormaPago,
                             ProximoPago = p.ProximoPago,
                             FechaInicio = p.FechaInicio,
                             FechaFin = p.FechaFin,
                             IdAseguradoras = p.IdAseguradoras,
                             Costo = p.Costo,
                             PrimaNeta = p.PrimaNeta,
                             IdEstadoPoliza = p.IdEstadoPoliza,
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
                             Marca = a.Marca,
                             Modelo = a.Modelo,
                             Ano = a.Ano,
                             Placas = a.Placas,
                             Clave = a.Clave,
                             CodigoPostal = a.CodigoPostal
                         };

            return result.ToList();
        }

        // GET: api/PolizaAuto/1231321
        [HttpGet("{id}")]
        public List<PolizaAuto> GetPolizaAutoDetalle(string id)
        {
            var result = from p in _context.Polizas
                         join a in _context.Auto on p.NoPoliza equals a.NoPoliza
                         where p.NoPoliza == id
                         select new PolizaAuto
                         {
                             NoPoliza = p.NoPoliza,
                             FormaPago = p.FormaPago,
                             ProximoPago = p.ProximoPago,
                             FechaInicio = p.FechaInicio,
                             FechaFin = p.FechaFin,
                             IdAseguradoras = p.IdAseguradoras,
                             Costo = p.Costo,
                             PrimaNeta = p.PrimaNeta,
                             IdEstadoPoliza = p.IdEstadoPoliza,
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
                             Marca = a.Marca,
                             Modelo = a.Modelo,
                             Ano = a.Ano,
                             Placas = a.Placas,
                             Clave = a.Clave,
                             CodigoPostal = a.CodigoPostal,
                         };

            return result.ToList();
        }
        // PUT: api/Polizas/5
        [HttpPut]
        public ResponseModel PutPolizaAuto([FromBody] PolizaAuto data)
        {
            try
            {
                Polizas poliza = new Polizas()
                {
                    TipoPoliza = 1,
                    NoPoliza = data.NoPoliza,
                    FormaPago = data.FormaPago,
                    ProximoPago = data.ProximoPago,
                    FechaInicio = data.FechaInicio,
                    FechaFin = data.FechaFin,
                    IdAseguradoras = data.IdAseguradoras,
                    Costo = data.Costo,
                    PrimaNeta = data.PrimaNeta,
                    IdEstadoPoliza = data.IdEstadoPoliza,
                    Username = data.Username,
                    ProductoId = data.ProductoId,
                    Habilitada = data.Habilitada,
                    NoAsegurado = data.NoAsegurado,
                    PolizaPropia = data.PolizaPropia,
                    //PolizaPdf = data.PolizaPdf,
                    //ReciboPdf = data.ReciboPdf,
                    RcUsaCanada = data.RcUsaCanada,
                    CostoPrimerRecibo = data.CostoPrimerRecibo,
                    CostoRecibosSubsecuentes = data.CostoRecibosSubsecuentes    
                };
                _context.Polizas.Update(poliza);

                Auto auto = new Auto()
                {
                    Marca = data.Marca,
                    Modelo = data.Modelo,
                    Ano = data.Ano,
                    Placas = data.Placas,
                    Clave = data.Clave,
                    CodigoPostal = data.CodigoPostal,
                    NoPoliza = data.NoPoliza
                };
                _context.Auto.Update(auto);

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
        public ResponseModel PostPolizaAuto([FromBody] PolizaAuto data)
        {
            try
            {
                Polizas poliza = new Polizas()
                {
                    TipoPoliza = 1,
                    NoPoliza = data.NoPoliza,
                    FormaPago = data.FormaPago,
                    ProximoPago = data.ProximoPago,
                    FechaInicio = data.FechaInicio,
                    FechaFin = data.FechaFin,
                    IdAseguradoras = data.IdAseguradoras,
                    Costo = data.Costo,
                    PrimaNeta = data.PrimaNeta,
                    Username = data.Username,
                    ProductoId = data.ProductoId,
                    Habilitada = data.Habilitada,
                    NoAsegurado = data.NoAsegurado,
                    PolizaPropia = _context.CartasNombramiento.Where(x => x.NoPoliza == data.NoPoliza).FirstOrDefault().Firmada ? "Si" : "No",
                    PolizaPdf = data.PolizaPdf,
                    //ReciboPdf = data.ReciboPdf,
                    RcUsaCanada = data.RcUsaCanada,
                    CostoPrimerRecibo = data.CostoPrimerRecibo,
                    CostoRecibosSubsecuentes = data.CostoRecibosSubsecuentes,
                    IdEstadoPoliza = 1,
                };
                _context.Polizas.Add(poliza);

                Auto auto = new Auto()
                {
                    Marca = data.Marca,
                    Modelo = data.Modelo,
                    Ano = data.Ano,
                    Placas = data.Placas,
                    Clave = data.Clave,
                    CodigoPostal = data.CodigoPostal,
                    NoPoliza = data.NoPoliza
                };
                _context.Auto.Add(auto);

                CartasNombramiento carta = _context.CartasNombramiento.Where(x => x.NoPoliza == data.NoPoliza).FirstOrDefault();
                carta.Revisado = true;
                _context.CartasNombramiento.Update(carta);

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
        public ResponseModel DeletePolizaAuto([FromBody] List<PolizaAuto> data)
        {
            try
            {
                foreach (var item in data)
                {
                    _context.Auto.Remove(_context.Auto.Where(x => x.NoPoliza == item.NoPoliza).FirstOrDefault());
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