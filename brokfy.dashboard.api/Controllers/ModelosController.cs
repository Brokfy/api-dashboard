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
    public class ModelosController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public ModelosController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Modelos
        [HttpGet]
        public List<ModelosModel> GetModelos([FromQuery] string Marca)
        {
            try
            {
                List<ModelosModel> marcas = _context.ModelosAseguradoras.Where(x => x.Marcas == Marca).Select(x => new ModelosModel { Marca = x.Marcas, Modelo = x.NomModelo }).Distinct().OrderBy(x => x.Modelo).ToList();
                return marcas;
            }
            catch (Exception ex)
            {
                return new List<ModelosModel>();
            }

        }
    }
}