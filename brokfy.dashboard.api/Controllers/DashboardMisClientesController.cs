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
    public class DashboardMisClientesController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public DashboardMisClientesController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/DashboardMisClientes
        [HttpGet]
        public List<DashboardMisClientes> GetDashboardPolizasPorVencer([FromQuery] string username)
        {
            try
            {
                DateTime proximaSemana = new DateTime().AddDays(7);
                List<DashboardMisClientes> consulta = (from pol in _context.Polizas
                                                       join ase in _context.Aseguradoras on pol.IdAseguradoras equals ase.IdAseguradora
                                                       join usu in _context.Perfil on pol.Username equals usu.Username
                                                       join edo in _context.EstadosPolizas on pol.IdEstadoPoliza equals edo.Id
                                                       join tip in _context.TipoPoliza on pol.TipoPoliza equals tip.Id
                                                       where pol.Username == username
                                                       select new DashboardMisClientes
                                                       {
                                                           //Aseguradora = ase.Nombre,
                                                           Nombre = string.Format(@"{0} {1} {2}", usu.Nombre, usu.ApellidoPaterno, usu.ApellidoMaterno),
                                                           Username = username,
                                                           NoPoliza = pol.NoPoliza,
                                                           TipoPoliza = tip.Tipo
                                                       }).ToList();
                return consulta;
            }
            catch (Exception ex)
            {
                return new List<DashboardMisClientes>();
            }

        }
    }
}