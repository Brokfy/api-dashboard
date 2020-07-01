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
using brokfy.dashboard.api.data.ViewModel;

namespace brokfy.dashboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestriccionesController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public RestriccionesController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Restricciones/
        [HttpGet]
        public List<Menu> GetRestricciones([FromQuery] string dato, [FromQuery] string campo)
        {
            List<Menu> respuesta = new List<Menu>();
            switch (campo)
            {
                case "token":
                    respuesta = (from p in _context.Menu
                                join r in _context.RestriccionesUsuarioMenu on p.IdMenu equals r.IdMenu
                                join u in _context.Usuario on r.Username equals u.Username
                                where u.TokenF == dato
                                select p).ToList();
                    break;
                case "username":
                    respuesta = (from p in _context.Menu
                                 join r in _context.RestriccionesUsuarioMenu on p.IdMenu equals r.IdMenu
                                 join u in _context.Usuario on r.Username equals u.Username
                                 where u.Username == dato
                                 select p).ToList();
                    break;
                default:
                    break;
            }

            return respuesta;
        }


        // POST: api/Aprobaciones
        [HttpPost("{username}")]
        public ResponseModel PostRestricciones([FromBody] List<RestriccionesUsuarioMenu> data, string username)
        {
            try
            {
                _context.RestriccionesUsuarioMenu.RemoveRange(_context.RestriccionesUsuarioMenu.Where(x => x.Username == username));
                _context.SaveChanges();

                _context.RestriccionesUsuarioMenu.AddRange(data);
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