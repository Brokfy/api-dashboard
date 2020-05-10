using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class PolizaPagoModel
    {
        [Key]
        public string NoPoliza { get; set; }
        public DateTime Vencimiento { get; set; }
        public int IdEstatusPoliza { get; set; }
        public double PrimaTotal { get; set; }
        public double PrimaNeta { get; set; }
        public double Comision { get; set; }
        public double MontoPagado { get; set; }
        public double MontoPago { get; set; }

    }
}
