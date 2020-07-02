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
    public class MenuController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public MenuController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Menu
        [HttpGet]
        public List<Menu> GetMenu()
        {
            var result = _context.Menu.ToList();
            return result.Where(x => x.IdMenuPadre == null).ToList();
        }
}
}