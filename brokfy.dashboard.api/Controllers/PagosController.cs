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
    public class PagosController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public PagosController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Pagos/
        [HttpGet]
        public List<Pagos> GetPagos([FromQuery] DateTime desde, [FromQuery] DateTime hasta)
        {
            var result = from p in _context.Pagos
                         where p.Fecha >= desde
                         && p.Fecha <= hasta
                         select p;

            return result.ToList();
        }


        // POST: api/Aprobaciones
        [HttpPost]
        public ResponseModel PostPagos([FromBody] Pagos data)
        {
            try
            {
                _context.Pagos.Add(data);
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }
    }
}