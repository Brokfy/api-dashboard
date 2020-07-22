﻿using System.Collections.Generic;
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
    public class SiniestrosController : ControllerBase
    {
        private readonly brokfy_devContext _context;
        private IConfiguration _config;
        public SiniestrosController(brokfy_devContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // GET: api/Siniestros
        [HttpGet]
        public List<SiniestroPolizaModel> GetSiniestros([FromQuery] int activo)
        {
            var query = (from pol in _context.Polizas
                         join polsin in _context.PolizaSiniestro on pol.NoPoliza equals polsin.NoPoliza
                         join poltip in _context.TipoPoliza on pol.TipoPoliza equals poltip.Id
                         join aseg in _context.Aseguradoras on pol.IdAseguradoras equals aseg.IdAseguradora
                         where pol.IdEstadoPoliza == 3 && polsin.Activo == activo
                         orderby polsin.IdPolizaSiniestro descending
                         select new SiniestroPolizaModel
                         {
                             IdPolizaSiniestro = polsin.IdPolizaSiniestro,
                             NoPoliza = pol.NoPoliza,
                             TipoPoliza = poltip.Tipo,
                             Aseguradora = aseg.Nombre,
                             Username = pol.Username,
                             FechaSiniestro = polsin.FechaSiniestro,
                             EstatusSiniestro = (from segsin in _context.SeguimientoSiniestro 
                                                join edosin in _context.EstadoSiniestro on segsin.IdEstadoSiniestro equals edosin.IdEstadoSiniestro
                                                where segsin.IdPolizaSiniestro == polsin.IdPolizaSiniestro
                                                orderby segsin.IdSeguimientoSiniestro descending
                                                select edosin.Nombre).FirstOrDefault()
                         }).ToList();
            return query;
            //return _context.Polizas.Where(x => x.IdEstadoPoliza == 3).ToList();
        }

        // GET: api/Siniestros/4554654
        [HttpGet("{IdPolizaSiniestro}")]
        public List<SeguimientoSiniestro> GetSiniestrosSeguimiento(int IdPolizaSiniestro)
        {
            try
            {
                var query = (from polsin in _context.PolizaSiniestro
                             join seg in _context.SeguimientoSiniestro on polsin.IdPolizaSiniestro equals seg.IdPolizaSiniestro
                             where seg.IdPolizaSiniestro == IdPolizaSiniestro
                             orderby seg.Fecha descending
                             select seg).ToList();
                return query;
            }
            catch (Exception ex)
            {
                return new List<SeguimientoSiniestro>();
            }
            
        }
    }
}