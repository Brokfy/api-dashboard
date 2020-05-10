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
    public class DetallePolizaController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public DetallePolizaController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        // GET: api/PolizaDetalle/151412
        [HttpGet("{NoPoliza}")]
        public PolizaDetalleModel GetPolizaDetalle(string NoPoliza)
        {
            PolizaDetalleModel dato = new PolizaDetalleModel() 
            {
                Poliza = _context.Polizas.Where(x => x.NoPoliza == NoPoliza).FirstOrDefault(),
                Pagos = new List<DetallePago>() { }
            };

            switch (dato.Poliza.TipoPoliza)
            {
                case 1:
                    dato.Poliza.Auto = _context.Auto.Where(x => x.NoPoliza == NoPoliza).FirstOrDefault();
                    break;
                case 5:
                    dato.Poliza.Vida = _context.Vida.Where(x => x.NoPoliza == NoPoliza).FirstOrDefault();
                    break;
                default:
                    break;
            }

            return dato;
        }
    }
}