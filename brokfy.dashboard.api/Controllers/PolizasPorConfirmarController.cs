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
        public IEnumerable<Polizas> GetPolizasPorConfirmar()
        {
            return _context.Polizas.Where(x => x.IdEstadoPoliza == 4).ToList();
        }

        // GET: api/PolizasPorConfirmar/4554654
        [HttpGet("{poliza}")]
        public Polizas GetPolizasPorConfirmar(string poliza)
        {
            return _context.Polizas.Where(x => x.NoPoliza == poliza).FirstOrDefault();
        }
    }
}