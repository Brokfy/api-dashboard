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
    public class GetDashboardInitController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public GetDashboardInitController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/GetDashboardInit
        [HttpGet]
        public DashboardModel GetDashboardInit()
        {
            try
            {
                DashboardModel modelos = new DashboardModel()
                {
                    clientes = (from cl in _context.Perfil
                                select new Clientes
                                {
                                    Nombre = string.Format(@"{0} {1} {2}", cl.Nombre, cl.ApellidoPaterno, cl.ApellidoMaterno),
                                    Username = cl.Username
                                }).ToList(),
                    tipoPoliza = _context.TipoPoliza.ToList()
                };
                return modelos;
            }
            catch (Exception ex)
            {
                return new DashboardModel();
            }

        }
    }
}