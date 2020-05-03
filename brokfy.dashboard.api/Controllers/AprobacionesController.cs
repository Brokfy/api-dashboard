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
    public class AprobacionesController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public AprobacionesController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Aprobaciones
        [HttpGet]
        public List<CartaNombramientoShowModel> GetAprobaciones()
        {
            var result = from cn in _context.CartasNombramiento
                         join p in _context.Perfil on cn.Username equals p.Username
                         where cn.Revisado == false
                         select new CartaNombramientoShowModel
                         {
                             Username = p.Username,
                             FullName = string.Format(@"{0} {1} {2}", p.Nombre, p.ApellidoPaterno, p.ApellidoMaterno),
                             Tipo = cn.Tipo,
                             Aseguradora = cn.Aseguradora,
                             Fecha = cn.Fecha,
                             NoPoliza = cn.NoPoliza,
                             Revisado = cn.Revisado,
                             UrlPoliza = cn.UrlPoliza,
                             UrlCartaNombramiento = cn.UrlCartaNombramiento,
                             Firmada = cn.Firmada
                         };
            return result.ToList(); 
            //_context.CartasNombramiento.Where(x => x.Revisado == false).ToList();
        }

        // GET: api/Aprobaciones/5
        [HttpGet("{id}")]
        public CartasNombramiento GetAprobaciones(string id)
        {
            var dato = _context.CartasNombramiento.Where(x => x.NoPoliza == id).FirstOrDefault();

            return dato;
        }
        // PUT: api/Aprobaciones/5
        [HttpPut]
        public ResponseModel PutAprobaciones([FromBody] CartasNombramiento data)
        {
            try
            {
                _context.CartasNombramiento.Update(data);
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/Aprobaciones
        [HttpPost]
        public ResponseModel PostCartasNombramiento([FromBody] CartasNombramiento data)
        {
            try
            {
                _context.CartasNombramiento.Add(data);
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/Aprobaciones/
        [HttpDelete]
        public ResponseModel DeleteCartasNombramiento([FromBody] CartasNombramiento data)
        {
            try
            {
                _context.CartasNombramiento.Remove(data);
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