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
        public dynamic GetReportes([FromBody] ReportesModel data)
        {
    
            //return _context.ReporteFacturacionTotales.FromSqlRaw(Where).ToList();
            return data.Nombre switch
            {
                "FacturacionTotal" => FacturacionTotal(data),
                "Comisiones" => Comisiones(data),
                "Siniestros" => FacturacionTotal(data),
                "PolizasPorVencer" => _context.ComisionActualModels.FromSqlRaw("Select * From brokfy_dev.vwAseguradorasComisionesActuales").ToList(),
                "BrokfyVSOtras" => _context.ComisionActualModels.FromSqlRaw("Select * From brokfy_dev.vwAseguradorasComisionesActuales").ToList(),
                "PolizasOtras" => _context.ComisionActualModels.FromSqlRaw("Select * From brokfy_dev.vwAseguradorasComisionesActuales").ToList(),
                _ => null,
            };
        }

        private List<ReporteFacturacionTotal> FacturacionTotal (ReportesModel data)
        {
            string Where = string.Format(@"
Set @FechaIni = '{0}';
Set @FechaFin = '{1}';
Set @Aseguradora = {2};
Set @TipoPoliza = {3};

Select 1 As TipoRegistro
	, aseguradoras.nombre As Aseguradora
	, Null As TipoPoliza
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Null As FechaInicio
    , Null As FormaPago
    , null As PrimaNeta
    , null As PrimaTotal
From polizas
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
Where polizas.fecha_inicio between @FechaIni and @FechaFin
	And polizas.poliza_propia = 'Si'
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
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Null As FechaInicio
	, Null As FormaPago
    , null As PrimaNeta
    , null As PrimaTotal
From polizas
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
Where polizas.fecha_inicio between @FechaIni and @FechaFin
	And polizas.poliza_propia = 'Si'
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
	, polizas.no_poliza As NumeroPoliza
    , polizas.username As Usuario
    , concat(perfil.nombre, ' ', perfil.apellido_paterno, ' ', perfil.apellido_materno)  As NombreUsuario
    , polizas.fecha_inicio As FechaInicio
	, polizas.forma_pago As FormaPago
    , polizas.prima_neta As PrimaNeta
    , polizas.costo As PrimaTotal
From polizas
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
	Inner Join perfil
		On perfil.username = polizas.username
Where polizas.fecha_inicio between @FechaIni and @FechaFin
	And polizas.poliza_propia = 'Si'
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
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Null As FechaInicio
	, Null As FormaPago
    , Sum(polizas.prima_neta) As PrimaNeta
    , Sum(polizas.costo) As PrimaTotal
From polizas
	Inner Join tipo_poliza
		On tipo_poliza.id = polizas.tipo_poliza
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
Where polizas.fecha_inicio between @FechaIni and @FechaFin
	And polizas.poliza_propia = 'Si'
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
    , Null As TipoPoliza
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Null As FechaInicio
	, Null As FormaPago
    , Sum(polizas.prima_neta) As PrimaNeta
    , Sum(polizas.costo) As PrimaTotal
From polizas
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
Where polizas.fecha_inicio between @FechaIni and @FechaFin
	And polizas.poliza_propia = 'Si'
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

Select 6 As TipoRegistro
	, 'ZZZZZZZZZZZ' As Aseguradora
    , Null As TipoPoliza
	, Null As NumeroPoliza
    , Null As Usuario
    , Null As NombreUsuario
    , Null As FechaInicio
	, Null As FormaPago
    , Sum(polizas.prima_neta) As PrimaNeta
    , Sum(polizas.costo) As PrimaTotal
From polizas
	Inner Join aseguradoras
		On aseguradoras.id_aseguradora = polizas.id_aseguradoras
Where polizas.fecha_inicio between @FechaIni and @FechaFin
	And polizas.poliza_propia = 'Si'
    And (
			( polizas.id_aseguradoras = @Aseguradora And @Aseguradora <> 0 )
            Or @Aseguradora = 0
		)
    And (
			( polizas.tipo_poliza = @TipoPoliza And @TipoPoliza <> 0 )
            Or @TipoPoliza = 0
		)

Order By Aseguradora, TipoRegistro, FechaInicio, NumeroPoliza;", data.FechaInicio, data.FechaFin, data.IdAseguradora == null ? 0 : data.IdAseguradora, data.IdTipoPoliza == null ? 0 : data.IdTipoPoliza);
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
Group By aseguradoras.nombre
	, tipo_poliza.tipo
    
Union All 

Select 5 As TipoRegistro
	, aseguradoras.nombre As Aseguradora
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
;", data.FechaInicio, data.FechaFin, data.IdAseguradora == null ? 0 : data.IdAseguradora, data.IdTipoPoliza == null ? 0 : data.IdTipoPoliza);
            return _context.ReporteComisiones.FromSqlRaw(Where).ToList();
        }
    }
}