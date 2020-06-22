using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PolizasPorSubirPerfilAsegurado
    {
        public int Id { get; set; }
        public string IdPerfil { get; set; }
        public string UrlPoliza { get; set; }

        public virtual PerfilAsegurado IdPerfilNavigation { get; set; }
    }
}
