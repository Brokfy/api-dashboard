using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PolizasPorSubir
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int IdTipoPoliza { get; set; }
        public string Fecha { get; set; }
        public bool Subido { get; set; }

        public virtual TipoPoliza IdTipoPolizaNavigation { get; set; }
        public virtual PerfilAsegurado UsernameNavigation { get; set; }
    }
}
