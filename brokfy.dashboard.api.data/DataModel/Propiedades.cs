using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Propiedades
    {
        public Propiedades()
        {
            PerfilAseguradoToPropiedades = new HashSet<PerfilAseguradoToPropiedades>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PerfilAseguradoToPropiedades> PerfilAseguradoToPropiedades { get; set; }
    }
}
