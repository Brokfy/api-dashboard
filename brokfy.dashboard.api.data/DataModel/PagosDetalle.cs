using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PagosDetalle
    {
        public int IdPagosDetalle { get; set; }
        public int IdPago { get; set; }
        public int IdPolizaComision { get; set; }
        public double Monto { get; set; }

        public virtual PolizasComisiones IdPolizaComisionNavigation { get; set; }
    }
}
