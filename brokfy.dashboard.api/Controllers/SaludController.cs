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
    public class SaludController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public SaludController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Salud
        [HttpGet]
        public List<Salud> GetSalud()
        {
            return _context.Salud.ToList();
        }

        // GET: api/Salud/5
        [HttpGet("{id}")]
        public Salud GetSalud(int id)
        {
            var dato = _context.Salud.Where(x => x.Id == id).FirstOrDefault();

            return dato;
        }
        // PUT: api/Salud/5
        [HttpPut]
        public ResponseModel PutSalud([FromBody] Salud data)
        {
            try
            {
                _context.Salud.Update(data);
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/Salud
        [HttpPost]
        public ResponseModel PostSalud([FromBody] Salud data)
        {
            try
            {
                _context.Salud.Add(data);
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/Salud/
        [HttpDelete]
        public ResponseModel DeleteSalud([FromBody] Salud data)
        {
            try
            {
                _context.Salud.Remove(data);
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