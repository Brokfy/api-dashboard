using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class DashboardPolizasPorVencer
    {
        public string NoPoliza { get; set; }
        public string TipoPoliza { get; set; }
        public DateTime FechaFin { get; set; }
        public string Aseguradora { get; set; }
    }
}
