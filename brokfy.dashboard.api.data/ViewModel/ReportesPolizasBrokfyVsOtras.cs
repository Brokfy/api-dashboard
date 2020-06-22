using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class ReportesPolizasBrokfyVsOtras
    {
        public int TipoRegistro { get; set; }
        public string Aseguradora { get; set; }
        public string TipoPoliza { get; set; }
        public double PrimaTotal { get; set; }
        public double ComisionesGeneradas { get; set; }
        public int Totalizador { get; set; }
    }
}
