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
    public class RegistroPagoController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public RegistroPagoController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Polizas/
        [HttpGet]
        public List<PolizaPagoModel> GetRegistroPago([FromQuery] int idAseguradora)
        {
            var result = from p in _context.Polizas
                         where p.IdAseguradoras == idAseguradora
                         select new PolizaPagoModel
                         {
                             NoPoliza = p.NoPoliza,
                             Vencimiento = p.FechaFin,
                             IdEstatusPoliza = 1,
                             PrimaTotal = p.Costo,
                             PrimaNeta = (p.Costo * 0.66),
                             Comision = (p.Costo * 0.66) / 10,
                             MontoPagado = 0.00,
                             MontoPago = 0.00

                         };

            return result.ToList();
        }

        
    }
}