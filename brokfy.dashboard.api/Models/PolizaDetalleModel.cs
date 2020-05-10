using brokfy.dashboard.api.data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brokfy.dashboard.api.Models
{
    public class PolizaDetalleModel
    {
        public Polizas Poliza { get; set; }
        //public dynamic Tipo { get; set; }
        public List<DetallePago> Pagos { get; set; }

    }

    public class DetallePago
    {
        public string NoPoliza { get; set; }
        public DateTime FechaPago { get; set; }
        public double MontoPago { get; set; }
        public int IdFormaPago { get; set; }
        public string Referencia { get; set; }
    }
}
