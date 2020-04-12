using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Salud
    {
        public Salud()
        {
            PerfilAseguradoToSalud = new HashSet<PerfilAseguradoToSalud>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PerfilAseguradoToSalud> PerfilAseguradoToSalud { get; set; }
    }
}
