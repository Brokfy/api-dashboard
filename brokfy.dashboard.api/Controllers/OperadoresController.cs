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
    public class OperadoresController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public OperadoresController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Operadores
        [HttpGet]
        public List<Perfil> GetOperadores([FromQuery] int tipo)
        {
            var result = from op in _context.Usuario
                         join per in _context.Perfil on op.Username equals per.Username
                         join utr in _context.UsuariosToRoles on op.Username equals utr.UsuarioId
                         where utr.RoleId == tipo
                         select per;
            return result.ToList();
        }
    }
}
