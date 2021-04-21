using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PerfilAseguradoVehiculos
    {
        public long Id { get; set; }
        public string IdPerfil { get; set; }
        public string Tipo { get; set; }
        public bool Asegurado { get; set; }

        public virtual PerfilAsegurado IdPerfilNavigation { get; set; }
    }
}
