using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PerfilAseguradoTieneGadgets
    {
        public long Id { get; set; }
        public string IdPerfil { get; set; }
        public int IdGadgets { get; set; }
        public bool? Seguro { get; set; }

        public virtual Gadgets IdGadgetsNavigation { get; set; }
        public virtual PerfilAsegurado IdPerfilNavigation { get; set; }
    }
}
