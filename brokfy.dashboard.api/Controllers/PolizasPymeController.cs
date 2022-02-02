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
    public class PolizasPymeController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public PolizasPymeController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/PolizaPyme/
        [HttpGet]
        public List<PolizaPyme> GetPolizaPyme([FromQuery] string propia)
        {
            var result = from p in _context.Polizas
                         join a in _context.Pyme on p.NoPoliza equals a.NoPoliza
                         where p.PolizaPropia == propia & p.TipoPoliza == 10
                         select new PolizaPyme
                         {
                             NoPoliza = p.NoPoliza,
                             FormaPago = p.FormaPago,
                             ProximoPago = p.ProximoPago,
                             FechaInicio = p.FechaInicio,
                             FechaFin = (DateTime)p.FechaFin,
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
                             CantidadNiveles = a.CantidadNiveles,
                             CercaMar = a.CercaMar,
                             Giro = a.Giro,
                             RazonSocial = a.RazonSocial,
                             Rfc = a.Rfc,
                             Subgiro = a.Subgiro,
                             TipoMuro = a.TipoMuro,
                             TipoTecho = a.TipoTecho
                         };

            return result.ToList();
        }

        // GET: api/PolizaPyme/1231321
        [HttpGet("{id}")]
        public List<PolizaPyme> GetPolizaPymeDetalle(string id)
        {
            var result = from p in _context.Polizas
                         join a in _context.Pyme on p.NoPoliza equals a.NoPoliza
                         where p.NoPoliza == id
                         select new PolizaPyme
                         {
                             NoPoliza = p.NoPoliza,
                             FormaPago = p.FormaPago,
                             ProximoPago = p.ProximoPago,
                             FechaInicio = p.FechaInicio,
                             FechaFin = (DateTime)p.FechaFin,
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
                             CantidadNiveles = a.CantidadNiveles,
                             CercaMar = a.CercaMar,
                             Giro = a.Giro,
                             RazonSocial = a.RazonSocial,
                             Rfc = a.Rfc,
                             Subgiro = a.Subgiro,
                             TipoMuro = a.TipoMuro,
                             TipoTecho = a.TipoTecho
                         };

            return result.ToList();
        }
        // PUT: api/Polizas/5
        [HttpPut]
        public ResponseModel PutPolizaPyme([FromBody] PolizaPyme data)
        {
            try
            {
                Polizas poliza = new Polizas()
                {
                    TipoPoliza = 10,
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

                Pyme pyme = new Pyme()
                {
                    CantidadNiveles = data.CantidadNiveles,
                    CercaMar = data.CercaMar,
                    Giro = data.Giro,
                    RazonSocial = data.RazonSocial,
                    Rfc = data.Rfc,
                    Subgiro = data.Subgiro,
                    TipoMuro = data.TipoMuro,
                    TipoTecho = data.TipoTecho
                };
                _context.Pyme.Update(pyme);

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
        public ResponseModel PostPolizaPyme([FromBody] PolizaPyme data)
        {
            try
            {
                Polizas poliza = new Polizas()
                {
                    TipoPoliza = 10,
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
                    IdEstadoPoliza = 4, // ESTADO POR CONFIRMAR
                };
                _context.Polizas.Add(poliza);

                Pyme pyme = new Pyme()
                {
                    CantidadNiveles = data.CantidadNiveles,
                    CercaMar = data.CercaMar,
                    Giro = data.Giro,
                    RazonSocial = data.RazonSocial,
                    Rfc = data.Rfc,
                    Subgiro = data.Subgiro,
                    TipoMuro = data.TipoMuro,
                    TipoTecho = data.TipoTecho
                };
                _context.Pyme.Add(pyme);

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
        public ResponseModel DeletePolizaPyme([FromBody] List<PolizaPyme> data)
        {
            try
            {
                foreach (var item in data)
                {
                    _context.Pyme.Remove(_context.Pyme.Where(x => x.NoPoliza == item.NoPoliza).FirstOrDefault());
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
