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


        // GET: api/Polizas/Mapfre

        [HttpGet]
        public List<PolizaPagoModel> GetPolizas([FromQuery] int idAseguradora, [FromQuery] string fecha)
        {

            //return _context.Polizas.Where(x => x.IdAseguradoras == idAseguradora ).ToList();
            
            var result = _context.PolizaPagoModels.FromSqlRaw(string.Format(@"Select TipoPoliza,no_poliza as NoPoliza,Total as Valor, Pagado as MontoPagado, Total-Pagado as Saldo, id_poliza_comision as IdPolizaComision, 0.0 as MontoPago, now() as Vencimiento 
	FROM (select polizas.tipo_poliza As TipoPoliza, polizas.no_poliza, sum(valor) as Total, polizas_comisiones.id_poliza_comision, 
		 coalesce((select sum(monto) 
			from pagos_detalle 
				where pagos_detalle.no_poliza = polizas_comisiones.no_poliza), 0.0) as Pagado 
					from polizas_comisiones join polizas on polizas.no_poliza = polizas_comisiones.no_poliza
						Where polizas.id_aseguradoras = {0}
			And polizas.poliza_propia = 'Si'
			And polizas.habilitada = 'Si'
			And polizas.id_estado_poliza = 1
            And polizas_comisiones.vencimiento < '{1}'
						group by polizas_comisiones.no_poliza) as Consulta
                        Where (Total - Pagado) > 0", idAseguradora, fecha)).ToList();
            foreach (PolizaPagoModel p in result)
            {
                p.Vencimiento = DateTime.Now;
            }
            return result;
        }

        /* [HttpGet]
         public List<PolizaPagoModel> GetPolizas([FromQuery] int idAseguradora, [FromQuery] string fecha)
         {

             //return _context.Polizas.Where(x => x.IdAseguradoras == idAseguradora ).ToList();
             var result = _context.PolizaPagoModels.FromSqlRaw(string.Format(@"Select *
 From (
         Select polizas.tipo_poliza As TipoPoliza,
             polizas.no_poliza As NoPoliza,
             Coalesce((Select Sum(monto) As valor from brokfy_dev.pagos_detalle where pagos_detalle.id_poliza_comision = polizas_comisiones.id_poliza_comision), 0.00) As MontoPagado,
             0.00 As MontoPago,
             polizas_comisiones.valor As Valor ,
             polizas_comisiones.vencimiento AS Vencimiento,
             polizas_comisiones.id_poliza_comision As IdPolizaComision
         From brokfy_dev.polizas
             Left Join brokfy_dev.polizas_comisiones
                 On polizas_comisiones.no_poliza = polizas.no_poliza
         Where polizas.id_aseguradoras = {0}
             And polizas.poliza_propia = 'Si'
             And polizas.habilitada = 'Si'
             And polizas.id_estado_poliza = 1
             And polizas_comisiones.vencimiento < '{1}'
     ) As Consulta
 Where valor > MontoPagado", idAseguradora, fecha)).ToList();
             return result;
         }*/
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