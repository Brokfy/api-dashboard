using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class EstadosPolizas
    {
        public EstadosPolizas()
        {
            Polizas = new HashSet<Polizas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Polizas> Polizas { get; set; }
    }
}
