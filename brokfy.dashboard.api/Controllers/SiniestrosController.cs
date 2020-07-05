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

namespace brokfy.dashboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiniestrosController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public SiniestrosController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Siniestros
        [HttpGet]
        public IEnumerable<Polizas> GetSiniestros()
        {
            return _context.Polizas.Where(x => x.IdEstadoPoliza == 3).ToList();
        }

        // GET: api/PolizasPorConfirmar/4554654
        [HttpGet("{poliza}")]
        public Polizas GetSiniestros(string poliza)
        {
            return _context.Polizas.Where(x => x.NoPoliza == poliza).FirstOrDefault();
        }
    }
}