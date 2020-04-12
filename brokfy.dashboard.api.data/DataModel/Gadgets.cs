using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Gadgets
    {
        public Gadgets()
        {
            PerfilAseguradoTieneGadgets = new HashSet<PerfilAseguradoTieneGadgets>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PerfilAseguradoTieneGadgets> PerfilAseguradoTieneGadgets { get; set; }
    }
}
