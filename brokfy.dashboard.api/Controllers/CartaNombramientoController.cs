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
    public class CartaNombramientoController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public CartaNombramientoController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/CartasNombramiento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartasNombramiento>>> GetCartasNombramiento()
        {
             return await _context.CartasNombramiento.ToListAsync();
        }

        // GET: api/CartasNombramiento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CartasNombramiento>> GetCartasNombramiento(int id)
        {
            var dato = await _context.CartasNombramiento.FindAsync(id);

            if (dato == null)
            {
                return NotFound();
            }

            return dato;
        }
        // PUT: api/CartasNombramiento/5
        [HttpPut]
        public async Task<ResponseModel> PutCartasNombramiento([FromBody] CartasNombramiento data)
        {
            try
            {
                    _context.CartasNombramiento.Update(data);
                    await _context.SaveChangesAsync();
                    return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/CartasNombramiento
        [HttpPost]
        public async Task<ResponseModel> PostCartasNombramiento([FromBody] CartasNombramiento data)
        {
            try
            {
                    _context.CartasNombramiento.Add(data);
                    await _context.SaveChangesAsync();
                    return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/CartasNombramiento/
        [HttpDelete]
        public async Task<ResponseModel> DeleteCartasNombramiento([FromBody] CartasNombramiento data)
        {
            try
            {
                    _context.CartasNombramiento.Remove(data);
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