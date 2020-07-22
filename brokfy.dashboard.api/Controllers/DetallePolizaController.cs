using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using brokfy.dashboard.api.data.DataModel;
using Microsoft.Extensions.Configuration;
using System;
using brokfy.dashboard.api.data.ViewModel;
using Newtonsoft.Json;
using brokfy.dashboard.api.Models;

namespace brokfy.dashboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetallePolizaController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public DetallePolizaController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        // GET: api/PolizaDetalle/151412
        [HttpGet("{NoPoliza}")]
        public data.ViewModel.PolizaDetalleModel GetPolizaDetalle(string NoPoliza)
        {
            
            try
            {
                Polizas original = _context.Polizas.Where(x => x.NoPoliza == NoPoliza).FirstOrDefault();
                List<AseguradorasComisiones> aseguradorasComisiones =
                    _context.AseguradorasComisiones.Where(x =>
                    x.IdAseguradora == original.IdAseguradoras
                    && DateTime.Now >= x.FechaInicioVigencia
                    && x.FechaFinVigencia == null).ToList();
                

                data.ViewModel.PolizaDetalleModel detalle = (from p in _context.Polizas
                           join ase in _context.Aseguradoras on p.IdAseguradoras equals ase.IdAseguradora
                           join pr in _context.Productos on p.ProductoId equals pr.Id
                           join usu in _context.Perfil on p.Username equals usu.Username
                           where p.NoPoliza == NoPoliza
                           select new data.ViewModel.PolizaDetalleModel
                           {
                               Poliza = new data.ViewModel.DetallePoliza
                                              {
                                                TipoPoliza = p.TipoPoliza ,
                                                NoPoliza = p.NoPoliza ,
                                                FormaPago = p.FormaPago ,
                                                FechaInicio = p.FechaInicio ,
                                                FechaFin = p.FechaFin ,
                                                IdAseguradora = p.IdAseguradoras ,
                                                NombreAseguradora = ase.Nombre ,
                                                ProductoId = p.ProductoId,
                                                NombreProducto = pr.Producto,
                                                Habilitada = p.Habilitada ,
                                                NoAsegurado = p.NoAsegurado ,
                                                PolizaPropia = p.PolizaPropia ,
                                                PolizaPdf = p.PolizaPdf ,
                                                ReciboPdf = p.ReciboPdf ,
                                                RcUsaCanada = p.RcUsaCanada ,
                                                CostoPrimerRecibo = p.CostoPrimerRecibo ,
                                                CostoRecibosSubsecuentes = p.CostoRecibosSubsecuentes ,
                                                PrimaTotal = p.Costo ,
                                                PrimaNeta = p.PrimaNeta ,
                                                Comision = (from com in _context.PolizasComisiones
                                                            where com.NoPoliza == NoPoliza
                                                            select com.Valor).Sum(),
                                                //aseguradorasComisiones.Count() > 0 ? (p.PrimaNeta * aseguradorasComisiones.FirstOrDefault().Valor)/100 : 0,
                                                Pagado = (from com in _context.PolizasComisiones
                                                          join det in _context.PagosDetalle on com.IdPolizaComision equals det.IdPolizaComision
                                                          where com.NoPoliza == NoPoliza
                                                          select det.Monto).Sum(),
                                                IdEstadoPoliza = p.IdEstadoPoliza ,
                                              },
                               Usuario = usu,
                               //Pagos = from px in _context.Polizas
                               //        join det in _context.PagosDetalle on px.NoPoliza equals det.NoPoliza
                               //        join pago in _context.Pagos on det.IdPago equals pago.IdPago
                               //        where det.NoPoliza == NoPoliza
                               //        select new HistoriaPagoPoliza
                               //        {
                               //            Fecha = pago.Fecha,
                               //            Monto = det.Monto,
                               //            Referencia = pago.Referencia,
                               //            FormaPago = "Transferencia Bancaria"
                               //            //pago.MetodoPago == 1 ? "Transferencia Bancaria" :
                               //            //pago.MetodoPago == 2 ? "Deposito Bancario" :
                               //            //pago.MetodoPago == 3 ? "Punto de Venta Electronico" :
                               //            //pago.MetodoPago == 4 ? "Efectivo" :
                               //            //                       "Otro"
                               //        },
                               Auto = p.TipoPoliza == 1 ? p.Auto : null,
                               Moto = p.TipoPoliza == 2 ? p.Auto : null,
                               //Hogar = p.Hogar,
                               //Salud = p.Salud,
                               Vida = p.Vida,
                               //Gadget = p.Gadget,
                               //Mascota = p.Mascota,
                               //Viaje = p.Viaje,
                               //Retiro = p.Retiro,
                               Pyme = p.Pyme,
                           }).FirstOrDefault();

                //detalle.Tipo = getTipoDetalle(original);
                detalle.Pagos = (from px in _context.Polizas
                                join com in _context.PolizasComisiones on px.NoPoliza equals com.NoPoliza
                                join det in _context.PagosDetalle on com.IdPolizaComision equals det.IdPolizaComision
                                join pago in _context.Pagos on det.IdPago equals pago.IdPago
                                where px.NoPoliza == NoPoliza
                                select new HistoriaPagoPoliza
                                {
                                    Fecha = pago.Fecha,
                                    Monto = det.Monto,
                                    Referencia = pago.Referencia,
                                    FormaPago = //"Transferencia Bancaria"
                                    pago.MetodoPago == 1 ? "Transferencia Bancaria" :
                                    pago.MetodoPago == 2 ? "Deposito Bancario" :
                                    pago.MetodoPago == 3 ? "Punto de Venta Electronico" :
                                    pago.MetodoPago == 4 ? "Efectivo" :
                                                           "Otro"
                                }).ToList();
                return detalle;
            }
            catch (Exception ex)
            {
                return new data.ViewModel.PolizaDetalleModel();
            }
            

            
        }

        private dynamic? getTipoDetalle(Polizas original)
        {
            switch (original.TipoPoliza)
            {
                case 1:
                    return _context.Auto.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                //case 2:
                //    return _context.Auto.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                //case 3:
                //    return _context.Auto.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                //case 4:
                //    return _context.Auto.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                case 5:
                    return _context.Vida.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                //case 6:
                //    return _context.Auto.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                //case 7:
                //    return _context.Auto.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                //case 8:
                //    return _context.Auto.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                //case 9:
                //    return _context.Auto.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                //case 10:
                //    return _context.Auto.Where(x => x.NoPoliza == original.NoPoliza).FirstOrDefault();
                default:
                    return null;
            }
        }
    }
}