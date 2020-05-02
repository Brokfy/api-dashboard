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
    public class ProductosController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public ProductosController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Productos
        [HttpGet]
        public IEnumerable<Productos> GetProductos()
        {
            return _context.Productos.ToList();
        }

        // GET: api/Productos/5
        [HttpGet("{id}")]
        public Productos GetProductos(int id)
        {
            return _context.Productos.Where(x => x.Id == id).FirstOrDefault();
        }
        // PUT: api/Productos/5
        [HttpPut]
        public ResponseModel PutProductos([FromBody] ProductosModel data)
        {
            try
            {
                
                _context.Productos.Update(new Productos() {
                    Id = data.Id,
                    Producto = data.Producto,
                    Aseguradora = int.Parse(data.Aseguradora),
                    Xml = data.Xml,
                    IdProductos = int.Parse(data.IdProductos),
                    XmlEmision = data.XmlEmision,
                });
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {

                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // POST: api/Productos
        [HttpPost]
        public ResponseModel PostProductos([FromBody] ProductosModel data)
        {
            try
            {
                _context.Productos.Add(new Productos()
                {
                    Id = data.Id,
                    Producto = data.Producto,
                    Aseguradora = int.Parse(data.Aseguradora),
                    Xml = data.Xml,
                    IdProductos = int.Parse(data.IdProductos),
                    XmlEmision = data.XmlEmision,
                });
                _context.SaveChanges();
                return new ResponseModel { Message = "Ok", Result = null, Success = true };
            }
            catch (Exception ex)
            {
                return new ResponseModel { Message = ex.InnerException != null ? ex.InnerException.Message : ex.Message, Result = null, Success = false };
            }
        }

        // DELETE: api/Productos/
        [HttpDelete]
        public ResponseModel DeleteProductos([FromBody] List<ProductosModel> data)
        {
            try
            {
                foreach (var item in data)
                {
                    _context.Productos.Remove(_context.Productos.Where(x => x.Id == item.Id).FirstOrDefault());
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