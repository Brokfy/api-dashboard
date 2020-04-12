using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Coberturas
    {
        public int IdCoberturas { get; set; }
        public string Tipo { get; set; }
        public long ProductosId { get; set; }

        public virtual Productos Productos { get; set; }
    }
}
