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
    public class InfoReportesController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public InfoReportesController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/InfoReportes
        [HttpGet]
        public IEnumerable<Reportes> GetInfoReportes()
        {
            return _context.Reportes.ToList();
        }
    }
}