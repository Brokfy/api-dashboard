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
    public class MarcaMotoController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public MarcaMotoController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/MarcaMoto
        [HttpGet]
        public List<ModelosMoto> GetMarcas()
        {
            try
            {
                List<ModelosMoto> marcas = _context.ModelosMoto.Select(x => new ModelosMoto { Marca = x.Marca }).Distinct().OrderBy(x => x.Marca).ToList();
                return marcas;
            }
            catch (Exception ex)
            {
                return new List<ModelosMoto>();
            }

        }
    }
}