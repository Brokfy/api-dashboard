using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PagosDetalle
    {
        public int IdPagosDetalle { get; set; }
        public int IdPago { get; set; }
        public string NoPoliza { get; set; }
        public double Monto { get; set; }

        public virtual Pagos IdPagoNavigation { get; set; }
    }
}
