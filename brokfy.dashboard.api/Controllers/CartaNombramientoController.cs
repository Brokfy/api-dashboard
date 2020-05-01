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
        public List<CartasNombramiento> GetCartasNombramiento()
        {
            var result = from cn in _context.CartasNombramiento
                         join p in _context.Perfil on cn.Username equals p.Username
                         where cn.Revisado == true && cn.Firmada == true
                         select new CartasNombramiento
                         {
                             Username = string.Format(@"{0} {1} {2} ({3})", p.Nombre, p.ApellidoPaterno, p.ApellidoMaterno, p.Username),
                             //Username = cn.Username,
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
            //return _context.CartasNombramiento.Where(x => x.Revisado == true && x.Firmada == true).ToList();
        }

        // GET: api/CartasNombramiento/5
        [HttpGet("{id}")]
        public CartasNombramiento GetCartasNombramiento(string id)
        {
            var dato = _context.CartasNombramiento.Where(x => x.NoPoliza == id).FirstOrDefault();

            return dato;
        }
        // PUT: api/CartasNombramiento/5
        [HttpPut]
        public ResponseModel PutCartasNombramiento([FromBody] CartasNombramiento data)
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

        // POST: api/CartasNombramiento
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

        // DELETE: api/CartasNombramiento/
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