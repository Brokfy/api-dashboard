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
    public class ValorComisionController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public ValorComisionController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/ValorComision
        [HttpGet]
        public double GetValorComision([FromQuery] int IdAseguradora, [FromQuery] int IdTipoPoliza, [FromQuery] DateTime Fecha)
        {
            return _context.AseguradorasComisiones.Where(x =>
            x.IdAseguradora == IdAseguradora
            && x.IdTipoPoliza == IdTipoPoliza
            && Fecha > x.FechaInicioVigencia
            && x.FechaFinVigencia == null).FirstOrDefault().Valor;
        }
    }
}