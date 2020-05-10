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
    public class ComisionesController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public ComisionesController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/AseguradorasComisiones
        [HttpGet]
        public IEnumerable<AseguradorasComisiones> GetAseguradorasComisiones()
        {
            return _context.AseguradorasComisiones.ToList();
        }

        // GET: api/AseguradorasComisiones/5
        [HttpGet("{idAseguradora}")]
        public AseguradorasComisiones GetAseguradorasComisiones(int idAseguradora)
        {
            return _context.AseguradorasComisiones.Where(x => x.IdAseguradora == idAseguradora).FirstOrDefault();
        }
        // PUT: api/AseguradorasComisiones/5
        [HttpPut]
        public ResponseModel PutAseguradorasComisiones([FromBody] AseguradorasComisiones data)
        {
            try
            {
                _context.AseguradorasComisiones.Update(data);
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/AseguradorasComisiones
        [HttpPost]
        public ResponseModel PostAseguradorasComisiones([FromBody] AseguradorasComisiones data)
        {
            try
            {
                _context.AseguradorasComisiones.Add(data);
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/AseguradorasComisiones/
        [HttpDelete]
        public ResponseModel DeleteAseguradorasComisiones([FromBody] List<AseguradorasComisiones> data)
        {
            try
            {
                foreach (var item in data)
                {
                    _context.AseguradorasComisiones.Remove(_context.AseguradorasComisiones.Where(x => x.IdAseguradora == item.IdAseguradora).FirstOrDefault());
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