﻿using System.Collections.Generic;
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
    public class GadgetsController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public GadgetsController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Gadgets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gadgets>>> GetGadgets()
        {
            return await _context.Gadgets.ToListAsync();
        }

        // GET: api/Gadgets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gadgets>> GetGadgets(int id)
        {
            var dato = await _context.Gadgets.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (dato == null)
            {
                return NotFound();
            }

            return dato;
        }
        // PUT: api/Gadgets/5
        [HttpPut]
        public async Task<ResponseModel> PutGadgets([FromBody] Gadgets data)
        {
            try
            {
                _context.Gadgets.Update(data);
                await _context.SaveChangesAsync();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/Gadgets
        [HttpPost]
        public async Task<ResponseModel> PostGadgets([FromBody] Gadgets data)
        {
            try
            {
                _context.Gadgets.Add(data);
                await _context.SaveChangesAsync();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/Gadgets/
        [HttpDelete]
        public async Task<ResponseModel> DeleteGadgets([FromBody] Gadgets data)
        {
            try
            {
                _context.Gadgets.Remove(data);
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