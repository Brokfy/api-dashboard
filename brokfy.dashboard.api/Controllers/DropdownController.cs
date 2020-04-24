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
        public async Task<ActionResult<List<DropdownListModel>>> GetDropdown(string id)
        {
            try
            {
                //aseguradoras,productos,tipo_poliza,usuario,auto
                List<string> list = id.Split(",").ToList();
                List<DropdownListModel> result = new List<DropdownListModel>();
                foreach (var item in list)
                {
                    DropdownListModel model = new DropdownListModel() { Table = item };
                    switch (item)
                    {
                        case "aseguradoras":
                            model.Data = await _context.Aseguradoras.ToListAsync();
                            break;
                        case "productos":
                            model.Data = await _context.Productos.ToListAsync();
                            break;
                        case "tipo_poliza":
                            model.Data = await _context.TipoPoliza.ToListAsync();
                            break;
                        case "usuario":
                            model.Data = await _context.Usuario.ToListAsync();
                            break;
                        case "auto":
                            model.Data = await _context.Auto.ToListAsync();
                            break;
                        default:
                            break;
                    }
                    result.Add(model);
                    //result.Add(_context.Database.ExecuteSqlRaw(string.Format(@"Select * From {0}", item)));
                }

                return result;
            }
            catch (Exception ex)
            {
                return new List<DropdownListModel>();
            }

        }
    }
}