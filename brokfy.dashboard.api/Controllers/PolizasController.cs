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
    public class PolizasController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public PolizasController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Polizas
        [HttpGet]
        public List<Polizas> GetPolizas()
        {
            return _context.Polizas.ToList();
        }

        // GET: api/Polizas/Mapfre

        [HttpGet("{idAseguradora}")]
        public List<PolizaPagoListModel> GetPolizasPorAseguradora(int idAseguradora)
        {
            //return _context.Polizas.Where(x => x.IdAseguradoras == idAseguradora ).ToList();
            var result = (from pol in _context.Polizas
                          join com in _context.PolizasComisiones on pol.NoPoliza equals com.NoPoliza
                          where pol.IdAseguradoras == idAseguradora
                          && pol.PolizaPropia == "Si"
                          && pol.Habilitada == "Si"
                          && pol.IdEstadoPoliza == 1
                          select new PolizaPagoListModel
                          {
                              TipoPoliza = pol.TipoPoliza,
                              NoPoliza = pol.NoPoliza,
                              MontoPagado = (from y in _context.PagosDetalle
                                             where y.IdPolizaComision == com.IdPolizaComision
                                             select y.Monto).Sum(),
                              MontoPago = 0,
                              Valor = com.Valor,
                              Vencimiento = com.Vencimiento,
                              IdPolizaComision = com.IdPolizaComision
                          }).ToList();
            return result;
        }
        // PUT: api/Polizas/5
        [HttpPut]
        public ResponseModel PutPolizas([FromBody] Polizas data)
        {
            try
            {
                _context.Polizas.Update(data);
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
        public ResponseModel PostPolizas([FromBody] Polizas data)
        {
            try
            {
                _context.Polizas.Add(data);
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
        public ResponseModel DeletePolizas([FromBody] Polizas data)
        {
            try
            {
                _context.Polizas.Remove(data);
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