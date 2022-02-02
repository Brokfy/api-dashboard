using brokfy.dashboard.api.data.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class PagosDetalleModel
    {
        public Pagos Pagos { get; set; }
        public PolizasComisiones Comisiones { get; set; }
    }
}
