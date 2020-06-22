using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PerfilAseguradoToPropiedades
    {
        public long Id { get; set; }
        public string IdPerfil { get; set; }
        public int IdPropiedades { get; set; }
        public bool Seguro { get; set; }

        public virtual PerfilAsegurado IdPerfilNavigation { get; set; }
        public virtual Propiedades IdPropiedadesNavigation { get; set; }
    }
}
