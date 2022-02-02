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
    public class DashboardConsultaPolizaController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public DashboardConsultaPolizaController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/DashboardConsultaPoliza
        [HttpGet]
        public DashboardConsultaPoliza GetDashboardConsultaPoliza([FromQuery] string noPoliza)
        {
            try
            {
                DashboardConsultaPoliza consulta = (from pol in _context.Polizas
                                                    join ase in _context.Aseguradoras on pol.IdAseguradoras equals ase.IdAseguradora
                                                    join usu in _context.Perfil on pol.Username equals usu.Username
                                                    join edo in _context.EstadosPolizas on pol.IdEstadoPoliza equals edo.Id
                                                    join tip in _context.TipoPoliza on pol.TipoPoliza equals tip.Id
                                                    where pol.NoPoliza == noPoliza
                                                    select new DashboardConsultaPoliza
                                                    {
                                                        Aseguradora = ase.Nombre,
                                                        Cliente = string.Format(@"{0} {1} {2}", usu.Nombre, usu.ApellidoPaterno, usu.ApellidoMaterno),
                                                        EstadoPoliza = edo.Nombre,
                                                        FechaInicio = pol.FechaInicio,
                                                        FechaFin = (DateTime)pol.FechaFin,
                                                        NoPoliza = noPoliza,
                                                        PolizaPropia = pol.PolizaPropia,
                                                        TipoPoliza = tip.Tipo
                                                    }).FirstOrDefault();
                return consulta;
            }
            catch (Exception ex)
            {
                return new DashboardConsultaPoliza();
            }

        }
    }
}