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
        public double MontoPagado { get; set; }
        public double MontoPago { get; set; }
        public int TipoPoliza { get; set; }
        public int IdPolizaComision { get; set; }
        public DateTime Vencimiento { get; set; }
        public double Valor { get; set; }

    }
}
