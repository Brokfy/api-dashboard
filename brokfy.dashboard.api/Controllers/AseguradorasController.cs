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
        public async Task<ActionResult<IEnumerable<Aseguradoras>>> GetAseguradoras()
        {
            return await _context.Aseguradoras.ToListAsync();
        }

        // GET: api/Aseguradoras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aseguradoras>> GetAseguradoras(string id)
        {
            var dato = await _context.Aseguradoras.Where(x => x.Nombre == id).FirstOrDefaultAsync();

            if (dato == null)
            {
                return NotFound();
            }

            return dato;
        }
        // PUT: api/Aseguradoras/5
        [HttpPut]
        public async Task<ResponseModel> PutAseguradoras([FromBody] Aseguradoras data)
        {
            try
            {
                _context.Aseguradoras.Update(data);
                await _context.SaveChangesAsync();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/Aseguradoras
        [HttpPost]
        public async Task<ResponseModel> PostAseguradoras([FromBody] Aseguradoras data)
        {
            try
            {
                _context.Aseguradoras.Add(data);
                await _context.SaveChangesAsync();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/Aseguradoras/
        [HttpDelete]
        public async Task<ResponseModel> DeleteAseguradoras([FromBody] Aseguradoras data)
        {
            try
            {
                _context.Aseguradoras.Remove(data);
                await _context.SaveChangesAsync();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }
    }
}