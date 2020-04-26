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
    public class PolizaAutoController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public PolizaAutoController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Polizas
        [HttpGet]
        public async Task<ActionResult<List<PolizaAuto>>> GetPolizaAuto()
        {
            var result = from p in _context.Polizas
                         join a in _context.Auto on p.NoPoliza equals a.NoPoliza
                         select new PolizaAuto
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
                             ReciboPdf = p.ReciboPdf,
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
                         
            return await result.ToListAsync();
        }

        // GET: api/Polizas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<PolizaAuto>>> GetPolizas(string id)
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
                             Username = p.Username,
                             ProductoId = p.ProductoId,
                             Habilitada = p.Habilitada,
                             NoAsegurado = p.NoAsegurado,
                             PolizaPropia = p.PolizaPropia,
                             PolizaPdf = p.PolizaPdf,
                             ReciboPdf = p.ReciboPdf,
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

            return await result.ToListAsync();
        }
        // PUT: api/Polizas/5
        [HttpPut]
        public async Task<ResponseModel> PutPolizas([FromBody] PolizaAuto data)
        {
            try
            {
                Polizas poliza = new Polizas()
                {
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
                    ReciboPdf = data.ReciboPdf,
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

                await _context.SaveChangesAsync();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/Polizas
        [HttpPost]
        public async Task<ResponseModel> PostPolizas([FromBody] PolizaAuto data)
        {
            try
            {
                Polizas poliza = new Polizas()
                {
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
                    ReciboPdf = data.ReciboPdf,
                    RcUsaCanada = data.RcUsaCanada,
                    CostoPrimerRecibo = data.CostoPrimerRecibo,
                    CostoRecibosSubsecuentes = data.CostoRecibosSubsecuentes
                };
                _context.Polizas.Update(poliza);
                await _context.SaveChangesAsync();

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
                await _context.SaveChangesAsync();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/Polizas/
        [HttpDelete]
        public async Task<ResponseModel> DeletePolizas([FromBody] PolizaAuto data)
        {
            try
            {
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

                Polizas poliza = new Polizas()
                {
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
                    ReciboPdf = data.ReciboPdf,
                    RcUsaCanada = data.RcUsaCanada,
                    CostoPrimerRecibo = data.CostoPrimerRecibo,
                    CostoRecibosSubsecuentes = data.CostoRecibosSubsecuentes
                };
                _context.Polizas.Remove(poliza);

                await _context.SaveChangesAsync();

                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }
    }
}