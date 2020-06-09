using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brokfy.dashboard.api.Models
{
    public class ReportesModel
    {
        public string Nombre { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public int? IdAseguradora { get; set; }
        public int? IdTipoPoliza { get; set; }

    }
}
