using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PerfilAseguradoToSalud
    {
        public string IdPerfil { get; set; }
        public int IdSalud { get; set; }
        public byte? Seguro { get; set; }

        public virtual PerfilAsegurado IdPerfilNavigation { get; set; }
        public virtual Salud IdSaludNavigation { get; set; }
    }
}
