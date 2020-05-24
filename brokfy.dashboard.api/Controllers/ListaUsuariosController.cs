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
    public class ListaUsuariosController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public ListaUsuariosController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/ListaUsuarios
        [HttpGet]
        public List<Perfil> GetListaUsuarios()
        {
            var result = _context.Perfil.ToList();
            return result.ToList();
        }

        //GET: api/ListaUsuarios/554654516
        [HttpGet("{username}")]
        public DetalleCliente GetListaUsuarios(string username)
        {
            var dato = (from us in _context.Perfil
                        join perf in _context.PerfilAsegurado on us.Username equals perf.IdPerfil
                        select new DetalleCliente { 
                            DatosPersonales = us,
                            PerfilAsegurado = perf
                        }).FirstOrDefault();
            dato.Polizas = _context.Polizas.Where(x => x.Username == username).ToList();
            return dato;
        }
    }
}