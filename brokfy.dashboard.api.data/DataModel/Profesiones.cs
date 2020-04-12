using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Profesiones
    {
        public Profesiones()
        {
            PerfilAsegurado = new HashSet<PerfilAsegurado>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PerfilAsegurado> PerfilAsegurado { get; set; }
    }
}
