using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class ReportePolizasPorVencer
    {
        public int TipoRegistro { get; set; }
        public string Aseguradora { get; set; }
        public string TipoPoliza { get; set; }
        public string ?NumeroPoliza { get; set; }
        public string ?Usuario { get; set; }
        public string ?NombreUsuario { get; set; }
        public DateTime ?FechaFin { get; set; }
        public int ?Totalizador { get; set; }
    }
}
