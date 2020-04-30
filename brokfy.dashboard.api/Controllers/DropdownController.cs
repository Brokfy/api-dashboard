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
        public List<DropdownListModel> GetDropdown(string id)
        {
            try
            {
                List<string> list = id.Split(",").ToList();
                List<DropdownListModel> result = new List<DropdownListModel>();
                foreach (var item in list)
                {
                    DropdownListModel model = new DropdownListModel() { Table = item };
                    switch (item)
                    {
                        case "aseguradoras":
                            model.Data =  _context.Aseguradoras.ToList();
                            break;
                        case "productos":
                            model.Data =  _context.Productos.ToList();
                            break;
                        case "tipo_poliza":
                            model.Data =  _context.TipoPoliza.ToList();
                            break;
                        case "usuario":
                            model.Data =  _context.Usuario.ToList();
                            break;
                        case "auto":
                            model.Data =  _context.Auto.ToList();
                            break;
                        default:
                            break;
                    }
                    result.Add(model);
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