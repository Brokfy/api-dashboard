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
    public class DashboardGraficoController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public DashboardGraficoController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/DashboardMisClientes
        [HttpGet]
        public List<DashboardGraficoModel> GetDashboardGrafico()
        {
            try
            {
                List<DashboardGraficoModel> consulta = (from pol in _context.Polizas
                group pol by pol.TipoPoliza into polGroup
                select new DashboardGraficoModel
                {
                    TipoPoliza = (from tipo in _context.TipoPoliza where tipo.Id == polGroup.Key select tipo.Tipo).FirstOrDefault(),
                    CantidadPolizas = polGroup.Count(),
                }).ToList();

                return consulta;
            }
            catch (Exception ex)
            {
                return new List<DashboardGraficoModel>();
            }

        }
    }

    
}