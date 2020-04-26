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
    public class AutoController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public AutoController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Auto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Auto>>> GetAuto()
        {
            return await _context.Auto.ToListAsync();
        }

        // GET: api/Auto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Auto>> GetAuto(string id)
        {
            var dato = await _context.Auto.Where(x => x.Placas == id).FirstOrDefaultAsync();

            if (dato == null)
            {
                return NotFound();
            }

            return dato;
        }
        // PUT: api/Auto/5
        [HttpPut]
        public async Task<ResponseModel> PutAuto([FromBody] Auto data)
        {
            try
            {
                _context.Auto.Update(data);
                await _context.SaveChangesAsync();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/Auto
        [HttpPost]
        public async Task<ResponseModel> PostAuto([FromBody] Auto data)
        {
            try
            {
                _context.Auto.Add(data);
                await _context.SaveChangesAsync();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/Auto/
        [HttpDelete]
        public async Task<ResponseModel> DeleteAuto([FromBody] Auto data)
        {
            try
            {
                _context.Auto.Remove(data);
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