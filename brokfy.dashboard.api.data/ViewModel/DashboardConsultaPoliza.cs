using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class DashboardConsultaPoliza
    {
        public string TipoPoliza { get; set; }
        public string NoPoliza { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Aseguradora { get; set; }
        public string Cliente { get; set; }
        public string EstadoPoliza { get; set; }
        public string PolizaPropia { get; set; }
    }
}
