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
    public class ReportesController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public ReportesController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
		[HttpGet]
		public dynamic GetReportes([FromQuery] string Nombre, [FromQuery] string FechaInicio, [FromQuery] string FechaFin, [FromQuery] int? IdAseguradora, [FromQuery] int? IdTipoPoliza)
        {
			ReportesModel data = new ReportesModel() { 
				Nombre = Nombre,
				FechaInicio = FechaInicio,
				FechaFin = FechaFin,	
				IdAseguradora = IdAseguradora,
				IdTipoPoliza = IdTipoPoliza
			};

            //return _context.ReporteFacturacionTotales.FromSqlRaw(Where).ToList();
            return data.Nombre switch
            {
                "FacturacionTotal" => FacturacionTotal(data),
                "Comisiones" => Comisiones(data),
				"ComisionesPendientes" => ComisionesPendientes(data),
				"Siniestros" => FacturacionTotal(data),
                "PolizasPorVencer" => _context.ComisionActualModels.FromSqlRaw("Select * From brokfy_dev.vwAseguradorasComisionesActuales").ToList(),
                "BrokfyVSOtras" => _context.ComisionActualModels.FromSqlRaw("Select * From brokfy_dev.vwAseguradorasComisionesActuales").ToList(),
                "PolizasOtras" => _context.ComisionActualModels.FromSqlRaw("Select * From brokfy_dev.vwAseguradorasComisionesActuales").ToList(),
                _ => null,
            };
        }

		private List<ReporteFacturacionTotal> FacturacionTotal(ReportesModel data)
		{
			string Where = string.Format(@"Call SpRptFacturacionTotal('{0}', '{1}', {2}, {3});", data.FechaInicio, data.FechaFin, data.IdAseguradora == null ? 0 : data.IdAseguradora, data.IdTipoPoliza == null ? 0 : data.IdTipoPoliza);
			return _context.ReporteFacturacionTotales.FromSqlRaw(Where).ToList();
		}


		private List<ReporteComisiones> Comisiones(ReportesModel data)
        {
            string Where = string.Format(@"Call SpRptComisionesRecibidas('{0}', '{1}', {2}, {3});", data.FechaInicio, data.FechaFin, data.IdAseguradora == null ? 0 : data.IdAseguradora, data.IdTipoPoliza == null ? 0 : data.IdTipoPoliza);
            return _context.ReporteComisiones.FromSqlRaw(Where).ToList();
        }

		private List<ReporteComisionesPendientes> ComisionesPendientes(ReportesModel data)
		{
			string Where = string.Format(@"Call SpRptComisionesPendientes('{0}', '{1}', {2}, {3});", data.FechaInicio, data.FechaFin, data.IdAseguradora == null ? 0 : data.IdAseguradora, data.IdTipoPoliza == null ? 0 : data.IdTipoPoliza);
			return _context.ReporteComisionesPendientes.FromSqlRaw(Where).ToList();
		}
	}
}