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
    public class ReciboPolizaController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public ReciboPolizaController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/ReciboPoliza/5
        [HttpGet("{id}")]
        public dynamic GetReciboPoliza(string id)
        {
            string dato = _context.Polizas.Where(x => x.NoPoliza == id).FirstOrDefault().ReciboPdf;

            return new { ReciboPdf = dato };
        }
    }
}