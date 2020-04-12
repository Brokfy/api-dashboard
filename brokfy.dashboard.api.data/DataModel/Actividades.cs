using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Actividades
    {
        public Actividades()
        {
            PerfilAseguradoToActividades = new HashSet<PerfilAseguradoToActividades>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PerfilAseguradoToActividades> PerfilAseguradoToActividades { get; set; }
    }
}
