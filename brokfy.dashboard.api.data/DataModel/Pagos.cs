using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Pagos
    {
        public Pagos()
        {
            PagosDetalle = new HashSet<PagosDetalle>();
        }

        public int IdPago { get; set; }
        public int IdAseguradora { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int MetodoPago { get; set; }
        public string Referencia { get; set; }

        public virtual Aseguradoras IdAseguradoraNavigation { get; set; }
        public virtual ICollection<PagosDetalle> PagosDetalle { get; set; }
    }
}
