using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using brokfy.dashboard.api.data.DataModel;
using Microsoft.Extensions.Configuration;
using brokfy.dashboard.api.Models;

namespace brokfy.dashboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizasPorConfirmarController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public PolizasPorConfirmarController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/PolizasPorConfirmar
        [HttpGet]
        public List<PolizaAutoPostModel> GetPolizasPorConfirmar()
        {
            var polizas = from p in _context.Polizas
                          where p.IdEstadoPoliza == 4 orderby p.FechaInicio descending
                          select new PolizaAutoPostModel
                          {
                              NoPoliza = p.NoPoliza,
                              FormaPago = p.FormaPago,
                              ProximoPago = p.ProximoPago.ToString("yyyy-MM-dd"),
                              FechaInicio = p.FechaInicio.ToString("yyyy-MM-dd"),
                              FechaFin = p.FechaFin.ToString("yyyy-MM-dd"),
                              IdAseguradoras = p.IdAseguradoras,
                              Costo = p.Costo,
                              Username = p.Username,
                              ProductoId = p.ProductoId,
                              Habilitada = p.Habilitada.Equals("Si") ? true:false,
                              NoAsegurado = p.NoAsegurado,
                              PolizaPropia = p.PolizaPropia,
                              PolizaPdf = p.PolizaPdf,
                              ReciboPdf = p.ReciboPdf,
                              RcUsaCanada = p.RcUsaCanada,
                              CostoPrimerRecibo = p.CostoPrimerRecibo,
                              CostoRecibosSubsecuentes = p.CostoRecibosSubsecuentes,
                              Marca = p.Auto.Marca,
                              Modelo = p.Auto.Modelo,
                              Ano = p.Auto.Ano,
                              Placas = p.Auto.Placas,
                              Clave = p.Auto.Clave,
                              CodigoPostal = p.Auto.CodigoPostal,
                          };
            return polizas.ToList();
        }

        // GET: api/PolizasPorConfirmar/4554654
        [HttpGet("{poliza}")]
        public PolizaAutoPostModel GetPolizasPorConfirmar(string poliza)
        {
            var polizas = from p in _context.Polizas
                          where p.IdEstadoPoliza == 4 orderby p.FechaInicio descending
                          select new PolizaAutoPostModel
                          {
                              NoPoliza = p.NoPoliza,
                              FormaPago = p.FormaPago,
                              ProximoPago = p.ProximoPago.ToString("yyyy-MM-dd"),
                              FechaInicio = p.FechaInicio.ToString("yyyy-MM-dd"),
                              FechaFin = p.FechaFin.ToString("yyyy-MM-dd"),
                              IdAseguradoras = p.IdAseguradoras,
                              Costo = p.Costo,
                              Username = p.Username,
                              ProductoId = p.ProductoId,
                              Habilitada = p.Habilitada.Equals("Si") ? true : false,
                              NoAsegurado = p.NoAsegurado,
                              PolizaPropia = p.PolizaPropia,
                              PolizaPdf = p.PolizaPdf,
                              ReciboPdf = p.ReciboPdf,
                              RcUsaCanada = p.RcUsaCanada,
                              CostoPrimerRecibo = p.CostoPrimerRecibo,
                              CostoRecibosSubsecuentes = p.CostoRecibosSubsecuentes,
                              Marca = p.Auto.Marca,
                              Modelo = p.Auto.Modelo,
                              Ano = p.Auto.Ano,
                              Placas = p.Auto.Placas,
                              Clave = p.Auto.Clave,
                              CodigoPostal = p.Auto.CodigoPostal,
                          };
            return polizas.First();
        }
    }
}