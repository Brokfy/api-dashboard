using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PolizasComisiones
    {
        public PolizasComisiones()
        {
            PagosDetalle = new HashSet<PagosDetalle>();
        }

        public int IdPolizaComision { get; set; }
        public string NoPoliza { get; set; }
        public DateTime Vencimiento { get; set; }
        public double Valor { get; set; }
        public bool Pagado { get; set; }

        public virtual Polizas NoPolizaNavigation { get; set; }
        public virtual ICollection<PagosDetalle> PagosDetalle { get; set; }
    }
}
