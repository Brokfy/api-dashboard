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
    public class YearController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public YearController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Year
        [HttpGet]
        public List<YearModel> GetYears([FromQuery] string Marca)
        {
            try
            {
                List<YearModel> year = _context.ModelosAseguradoras.Where(x => x.Marcas == Marca).Select(x => new YearModel { Year = x.AnioComercializacion, Marca = x.Marcas }).Distinct().OrderByDescending(x => x.Year).ToList();
                return year;
            }
            catch (Exception ex)
            {
                return new List<YearModel>();
            }

        }
    }
}