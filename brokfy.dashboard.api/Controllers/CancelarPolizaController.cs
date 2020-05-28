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
    public class CancelarPolizaController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public CancelarPolizaController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // PUT: api/CancelarPoliza
        [HttpPut("{noPoliza}")]
        public ResponseModel PutCancelarPoliza(string noPoliza)
        {
            try
            {
                Polizas poliza = _context.Polizas.Where(x => x.NoPoliza == noPoliza).FirstOrDefault();
                poliza.IdEstadoPoliza = 2;
                _context.Polizas.Update(poliza);
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