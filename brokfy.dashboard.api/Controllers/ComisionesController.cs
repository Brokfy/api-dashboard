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
        public List<ComisionActualModel> GetAseguradorasComisiones()
        {
            return _context.ComisionActualModels.FromSqlRaw("Select * From brokfy_dev.vwAseguradorasComisionesActuales").ToList();
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
        public ResponseModel PostAseguradorasComisiones([FromBody] ComisionActualModel data)
        {
            try
            {
                List<AseguradorasComisiones> comisiones = (from com in _context.AseguradorasComisiones
                                                           where com.FechaInicioVigencia <= DateTime.Now 
                                                           && com.FechaFinVigencia >= DateTime.Now 
                                                           && com.IdAseguradora == data.id_aseguradora
                                                           select com).ToList();
                
                ArmarObjeto(comisiones, data.id_aseguradora, 1, data.Auto);
                ArmarObjeto(comisiones, data.id_aseguradora, 2, data.Moto);
                ArmarObjeto(comisiones, data.id_aseguradora, 3, data.Hogar);
                ArmarObjeto(comisiones, data.id_aseguradora, 4, data.Salud);
                ArmarObjeto(comisiones, data.id_aseguradora, 5, data.Vida);
                ArmarObjeto(comisiones, data.id_aseguradora, 6, data.Gadget);
                ArmarObjeto(comisiones, data.id_aseguradora, 7, data.Mascota);
                ArmarObjeto(comisiones, data.id_aseguradora, 8, data.Viaje);
                ArmarObjeto(comisiones, data.id_aseguradora, 9, data.Retiro);
                ArmarObjeto(comisiones, data.id_aseguradora, 10, data.Pyme);



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


        private void ArmarObjeto(List<AseguradorasComisiones> comisiones, int IdAseguradora, int IdTipoPoliza, double Valor)
        {
            bool Saltar = false;

            if (comisiones.Where(x => x.IdTipoPoliza == IdTipoPoliza).Count() > 0)
            {
                AseguradorasComisiones Existe = comisiones.Where(x => x.IdTipoPoliza == IdTipoPoliza).FirstOrDefault();
                if (Existe.Valor == Valor)
                    Saltar = true;
                else
                {
                    Existe.FechaFinVigencia = DateTime.Now.AddSeconds(-1);
                    _context.AseguradorasComisiones.Update(Existe);
                }

            }
            if (!Saltar)
            {
                AseguradorasComisiones registro = new AseguradorasComisiones()
                {
                    FechaInicioVigencia = DateTime.Now,
                    FechaFinVigencia = DateTime.Now.AddYears(1),
                    IdAseguradora = IdAseguradora,
                    IdTipoPoliza = IdTipoPoliza,
                    Valor = Valor
                };
                _context.AseguradorasComisiones.Add(registro);
            }
        }
    }
}