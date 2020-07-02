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
    public class DashboardPolizasPorVencerController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public DashboardPolizasPorVencerController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/DashboardPolizasPorVencer
        [HttpGet]
        public List<DashboardPolizasPorVencer> GetDashboardPolizasPorVencer([FromQuery] int tipoPoliza)
        {
            try
            {
                DateTime proximaSemana = new DateTime().AddDays(7);
                List<DashboardPolizasPorVencer> consulta = (from pol in _context.Polizas
                                                    join ase in _context.Aseguradoras on pol.IdAseguradoras equals ase.IdAseguradora
                                                    join tip in _context.TipoPoliza on pol.TipoPoliza equals tip.Id
                                                    where pol.TipoPoliza == tipoPoliza
                                                    && pol.FechaFin <= proximaSemana
                                                    && pol.FechaFin >= DateTime.Now
                                                            select new DashboardPolizasPorVencer
                                                    {
                                                        Aseguradora = ase.Nombre,
                                                        FechaFin = pol.FechaFin,
                                                        NoPoliza = pol.NoPoliza,
                                                        TipoPoliza = tip.Tipo
                                                    }).OrderBy(x => x.FechaFin)
                                                    .ThenBy(x => x.NoPoliza)
                                                    .ToList();
                return consulta;
            }
            catch (Exception ex)
            {
                return new List<DashboardPolizasPorVencer>();
            }

        }
    }
}