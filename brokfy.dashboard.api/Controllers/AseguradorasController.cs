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
    public class AseguradorasController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public AseguradorasController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Aseguradoras
        [HttpGet]
        public IEnumerable<Aseguradoras> GetAseguradoras()
        {
            return _context.Aseguradoras.ToList();
        }

        // GET: api/Aseguradoras/5
        [HttpGet("{id}")]
        public Aseguradoras GetAseguradoras(string id)
        {
            return _context.Aseguradoras.Where(x => x.Nombre == id).FirstOrDefault();
        }
        // PUT: api/Aseguradoras/5
        [HttpPut]
        public ResponseModel PutAseguradoras([FromBody] Aseguradoras data)
        {
            try
            {
                _context.Aseguradoras.Update(data);
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/Aseguradoras
        [HttpPost]
        public ResponseModel PostAseguradoras([FromBody] Aseguradoras data)
        {
            try
            {
                _context.Aseguradoras.Add(data);
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/Aseguradoras/
        [HttpDelete]
        public ResponseModel DeleteAseguradoras([FromBody] List<Aseguradoras> data)
        {
            try
            {
                foreach (var item in data)
                {
                    _context.Aseguradoras.Remove(_context.Aseguradoras.Where(x => x.IdAseguradora == item.IdAseguradora).FirstOrDefault());
                }
                
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