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
            string Where = string.Format(@"Set @FechaIni = '{0}';
Set @FechaFin = '{1}';
Set @Aseguradora = {2};
Set @TipoPoliza = {3};

Select 1 As TipoRegistro
	, aseguradoras.nombre As Aseguradora
	, Null As TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Null As MontoPago
From pagos
	Inner Join pagos_detalle
		On pagos_detalle.id_pago = pagos.id_pago
	Inner Join polizas_comisiones
		On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
	Inner Join polizas
		On polizas.no_poliza = polizas_comisiones.no_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
Where pagos.fecha between @FechaIni and @FechaFin
    And (
			( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
            Or @Aseguradora = 0
		)
    And (
			( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
            Or @TipoPoliza = 0
		)
Group By aseguradoras.nombre

Union All 

Select 2 As TipoRegistro
	, aseguradoras.nombre As Aseguradora
	, tipo_poliza.tipo As TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Null As MontoPago
From pagos
	Inner Join pagos_detalle
		On pagos_detalle.id_pago = pagos.id_pago
	Inner Join polizas_comisiones
		On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
	Inner Join polizas
		On polizas.no_poliza = polizas_comisiones.no_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
Where pagos.fecha between @FechaIni and @FechaFin
    And (
			( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
            Or @Aseguradora = 0
		)
    And (
			( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
            Or @TipoPoliza = 0
		)
Group By aseguradoras.nombre
	, tipo_poliza.tipo
    
Union All 

Select 3 As TipoRegistro
	, aseguradoras.nombre As Aseguradora
	, tipo_poliza.tipo As TipoPoliza
    , pagos.fecha As FechaPago
	, polizas.no_poliza As NumeroPoliza
    , polizas.username As Usuario
    , concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)  As NombreUsuario
    , pagos_detalle.monto As MontoPago
From pagos
	Inner Join pagos_detalle
		On pagos_detalle.id_pago = pagos.id_pago
	Inner Join polizas_comisiones
		On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
	Inner Join polizas
		On polizas.no_poliza = polizas_comisiones.no_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
	Inner Join perfil
		On perfil.username = polizas.username
Where pagos.fecha between @FechaIni and @FechaFin
    And (
			( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
            Or @Aseguradora = 0
		)
    And (
			( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
            Or @TipoPoliza = 0
		)
        
Union All 

Select 4 As TipoRegistro
	, aseguradoras.nombre As Aseguradora
	, tipo_poliza.tipo As TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Sum(pagos_detalle.monto) As MontoPago
From pagos
	Inner Join pagos_detalle
		On pagos_detalle.id_pago = pagos.id_pago
	Inner Join polizas_comisiones
		On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
	Inner Join polizas
		On polizas.no_poliza = polizas_comisiones.no_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
Where pagos.fecha between @FechaIni and @FechaFin
    And (
			( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
            Or @Aseguradora = 0
		)
    And (
			( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
            Or @TipoPoliza = 0
		)
Group By aseguradoras.nombre
	, tipo_poliza.tipo
    
Union All 

Select 5 As TipoRegistro
	, aseguradoras.nombre As Aseguradora
	, 'ZZZZZZZZZZZ' As TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Sum(pagos_detalle.monto) As MontoPago
From pagos
	Inner Join pagos_detalle
		On pagos_detalle.id_pago = pagos.id_pago
	Inner Join polizas_comisiones
		On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
	Inner Join polizas
		On polizas.no_poliza = polizas_comisiones.no_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
Where pagos.fecha between @FechaIni and @FechaFin
Group By aseguradoras.nombre

Union All 

Select 6 As TipoRegistro
	, 'ZZZZZZZZZZZ' As Aseguradora
	, Null As TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Sum(pagos_detalle.monto) As MontoPago
From pagos
	Inner Join pagos_detalle
		On pagos_detalle.id_pago = pagos.id_pago
	Inner Join polizas_comisiones
		On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
	Inner Join polizas
		On polizas.no_poliza = polizas_comisiones.no_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
Where pagos.fecha between @FechaIni and @FechaFin
    And (
			( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
            Or @Aseguradora = 0
		)
    And (
			( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
            Or @TipoPoliza = 0
		)
        
Order By Aseguradora, TipoPoliza, TipoRegistro, FechaPago, NumeroPoliza;
;", data.FechaInicio, data.FechaFin, data.IdAseguradora == null ? 0 : data.IdAseguradora, data.IdTipoPoliza == null ? 0 : data.IdTipoPoliza);
            return _context.ReporteComisiones.FromSqlRaw(Where).ToList();
        }

		private List<ReporteComisionesPendientes> ComisionesPendientes(ReportesModel data)
		{
			string Where = string.Format(@"Set @FechaIni = '{0}';
Set @FechaFin = '{1}';
Set @Aseguradora = {2};
Set @TipoPoliza = {3};

Select Consulta.TipoRegistro
	, Consulta.Aseguradora As Aseguradora
	, Null As TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Sum(Consulta.MontoComision) As MontoComision
    , Sum(Consulta.MontoPagado) As MontoPagado
    , Sum(Consulta.MontoPendiente) As MontoPendiente
From (
		Select 1 As TipoRegistro
			, aseguradoras.nombre As Aseguradora
			, tipo_poliza.tipo As TipoPoliza
			, pagos.fecha As FechaPago
			, polizas.no_poliza As NumeroPoliza
			, polizas.username As Usuario
			, concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)  As NombreUsuario
			, polizas_comisiones.valor As MontoComision
			, Sum(pagos.monto) As MontoPagado
			, Round(polizas_comisiones.valor - Sum(pagos.monto), 2) As MontoPendiente
		From pagos
			Inner Join pagos_detalle
				On pagos_detalle.id_pago = pagos.id_pago
			Inner Join polizas_comisiones
				On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
			Inner Join polizas
				On polizas.no_poliza = polizas_comisiones.no_poliza
			Inner Join aseguradoras
				On aseguradoras.id_aseguradora = polizas.id_aseguradoras
			Inner Join tipo_poliza
				On tipo_poliza.id = polizas.tipo_poliza
			Inner Join perfil
				On perfil.username = polizas.username
		Where polizas_comisiones.vencimiento <= @FechaFin
			And (
					( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
					Or @Aseguradora = 0
				)
			And (
					( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
					Or @TipoPoliza = 0
				)
		Group By aseguradoras.nombre
			, tipo_poliza.tipo
			, pagos.fecha
			, polizas.no_poliza
			, polizas.username
			, concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)
			, polizas_comisiones.valor
		Having polizas_comisiones.valor > Sum(pagos.monto)
    ) As Consulta
Group By Consulta.TipoRegistro
	, Consulta.Aseguradora

Union All 

Select 2 As TipoRegistro
	, aseguradoras.nombre As Aseguradora
	, tipo_poliza.tipo As TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Null As MontoComision
    , Null As MontoPagado
    , Null As MontoPendiente
From pagos
	Inner Join pagos_detalle
		On pagos_detalle.id_pago = pagos.id_pago
	Inner Join polizas_comisiones
		On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
	Inner Join polizas
		On polizas.no_poliza = polizas_comisiones.no_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
Where polizas_comisiones.vencimiento <= @FechaFin
    And (
			( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
            Or @Aseguradora = 0
		)
    And (
			( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
            Or @TipoPoliza = 0
		)
Group By aseguradoras.nombre
	, tipo_poliza.tipo
Having Sum(polizas_comisiones.valor) > Sum(pagos.monto)
    
Union All 

Select 3 As TipoRegistro
	, aseguradoras.nombre As Aseguradora
	, tipo_poliza.tipo As TipoPoliza
    , pagos.fecha As FechaPago
	, polizas.no_poliza As NumeroPoliza
    , polizas.username As Usuario
    , concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)  As NombreUsuario
    , polizas_comisiones.valor As MontoComision
    , Sum(pagos.monto) As MontoPagado
    , Round(polizas_comisiones.valor - Sum(pagos.monto), 2) As MontoPendiente
From pagos
	Inner Join pagos_detalle
		On pagos_detalle.id_pago = pagos.id_pago
	Inner Join polizas_comisiones
		On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
	Inner Join polizas
		On polizas.no_poliza = polizas_comisiones.no_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
	Inner Join perfil
		On perfil.username = polizas.username
Where polizas_comisiones.vencimiento <= @FechaFin
    And (
			( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
            Or @Aseguradora = 0
		)
    And (
			( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
            Or @TipoPoliza = 0
		)
Group By aseguradoras.nombre
	, tipo_poliza.tipo
    , pagos.fecha
	, polizas.no_poliza
    , polizas.username
    , concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)
    , polizas_comisiones.valor
Having polizas_comisiones.valor > Sum(pagos.monto)
        
Union All 

Select Consulta.TipoRegistro
	, Consulta.Aseguradora
	, Consulta.TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Sum(Consulta.MontoComision) As MontoComision
    , Sum(Consulta.MontoPagado) As MontoPagado
    , Sum(Consulta.MontoPendiente) As MontoPendiente
From (
		Select 4 As TipoRegistro
			, aseguradoras.nombre As Aseguradora
			, tipo_poliza.tipo As TipoPoliza
			, pagos.fecha As FechaPago
			, polizas.no_poliza As NumeroPoliza
			, polizas.username As Usuario
			, concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)  As NombreUsuario
			, polizas_comisiones.valor As MontoComision
			, Sum(pagos.monto) As MontoPagado
			, Round(polizas_comisiones.valor - Sum(pagos.monto), 2) As MontoPendiente
		From pagos
			Inner Join pagos_detalle
				On pagos_detalle.id_pago = pagos.id_pago
			Inner Join polizas_comisiones
				On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
			Inner Join polizas
				On polizas.no_poliza = polizas_comisiones.no_poliza
			Inner Join aseguradoras
				On aseguradoras.id_aseguradora = polizas.id_aseguradoras
			Inner Join tipo_poliza
				On tipo_poliza.id = polizas.tipo_poliza
			Inner Join perfil
				On perfil.username = polizas.username
		Where polizas_comisiones.vencimiento <= @FechaFin
			And (
					( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
					Or @Aseguradora = 0
				)
			And (
					( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
					Or @TipoPoliza = 0
				)
		Group By aseguradoras.nombre
			, tipo_poliza.tipo
			, pagos.fecha
			, polizas.no_poliza
			, polizas.username
			, concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)
			, polizas_comisiones.valor
		Having polizas_comisiones.valor > Sum(pagos.monto)
    ) As Consulta
Group By Consulta.TipoRegistro
	, Consulta.Aseguradora
	, Consulta.TipoPoliza

Union All 

Select Consulta.TipoRegistro
	, Consulta.Aseguradora
	, 'ZZZZZZZZZZZ' As TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Sum(Consulta.MontoComision) As MontoComision
    , Sum(Consulta.MontoPagado) As MontoPagado
    , Sum(Consulta.MontoPendiente) As MontoPendiente
From (
		Select 5 As TipoRegistro
			, aseguradoras.nombre As Aseguradora
			, tipo_poliza.tipo As TipoPoliza
			, pagos.fecha As FechaPago
			, polizas.no_poliza As NumeroPoliza
			, polizas.username As Usuario
			, concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)  As NombreUsuario
			, polizas_comisiones.valor As MontoComision
			, Sum(pagos.monto) As MontoPagado
			, Round(polizas_comisiones.valor - Sum(pagos.monto), 2) As MontoPendiente
		From pagos
			Inner Join pagos_detalle
				On pagos_detalle.id_pago = pagos.id_pago
			Inner Join polizas_comisiones
				On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
			Inner Join polizas
				On polizas.no_poliza = polizas_comisiones.no_poliza
			Inner Join aseguradoras
				On aseguradoras.id_aseguradora = polizas.id_aseguradoras
			Inner Join tipo_poliza
				On tipo_poliza.id = polizas.tipo_poliza
			Inner Join perfil
				On perfil.username = polizas.username
		Where polizas_comisiones.vencimiento <= @FechaFin
			And (
					( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
					Or @Aseguradora = 0
				)
			And (
					( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
					Or @TipoPoliza = 0
				)
		Group By aseguradoras.nombre
			, tipo_poliza.tipo
			, pagos.fecha
			, polizas.no_poliza
			, polizas.username
			, concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)
			, polizas_comisiones.valor
		Having polizas_comisiones.valor > Sum(pagos.monto)
    ) As Consulta
Group By Consulta.TipoRegistro
	, Consulta.Aseguradora
    
Union All 

Select Consulta.TipoRegistro
	, 'ZZZZZZZZZZZ' As Aseguradora
	, Null As TipoPoliza
    , Null As FechaPago
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Sum(Consulta.MontoComision) As MontoComision
    , Sum(Consulta.MontoPagado) As MontoPagado
    , Sum(Consulta.MontoPendiente) As MontoPendiente
From (
		Select 6 As TipoRegistro
			, aseguradoras.nombre As Aseguradora
			, tipo_poliza.tipo As TipoPoliza
			, pagos.fecha As FechaPago
			, polizas.no_poliza As NumeroPoliza
			, polizas.username As Usuario
			, concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)  As NombreUsuario
			, polizas_comisiones.valor As MontoComision
			, Sum(pagos.monto) As MontoPagado
			, Round(polizas_comisiones.valor - Sum(pagos.monto), 2) As MontoPendiente
		From pagos
			Inner Join pagos_detalle
				On pagos_detalle.id_pago = pagos.id_pago
			Inner Join polizas_comisiones
				On polizas_comisiones.id_poliza_comision = pagos_detalle.id_poliza_comision
			Inner Join polizas
				On polizas.no_poliza = polizas_comisiones.no_poliza
			Inner Join aseguradoras
				On aseguradoras.id_aseguradora = polizas.id_aseguradoras
			Inner Join tipo_poliza
				On tipo_poliza.id = polizas.tipo_poliza
			Inner Join perfil
				On perfil.username = polizas.username
		Where polizas_comisiones.vencimiento <= @FechaFin
			And (
					( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
					Or @Aseguradora = 0
				)
			And (
					( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
					Or @TipoPoliza = 0
				)
		Group By aseguradoras.nombre
			, tipo_poliza.tipo
			, pagos.fecha
			, polizas.no_poliza
			, polizas.username
			, concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)
			, polizas_comisiones.valor
		Having polizas_comisiones.valor > Sum(pagos.monto)
    ) As Consulta
Group By Consulta.TipoRegistro

Order By Aseguradora, TipoPoliza, TipoRegistro, FechaPago, NumeroPoliza;", data.FechaInicio, data.FechaFin, data.IdAseguradora == null ? 0 : data.IdAseguradora, data.IdTipoPoliza == null ? 0 : data.IdTipoPoliza);
			return _context.ReporteComisionesPendientes.FromSqlRaw(Where).ToList();
		}
	}
}