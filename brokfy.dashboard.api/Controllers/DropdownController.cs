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

namespace brokfy.dashboard.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DropdownController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public DropdownController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<object>>> GetDropdown(string id)
        {
            try
            {
                List<string> list = id.Split(",").ToList();
                List<object> result = new List<object>();
                foreach (var item in list)
                {
                    result.Add(_context.Database.ExecuteSqlRaw(string.Format(@"Select * From {0}", item)));
                }

                return result;
            }
            catch (Exception ex)
            {
                return new List<object>();
            }
            
        }
    }
}