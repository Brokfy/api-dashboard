using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class CartasNombramiento
    {
        public string Username { get; set; }
        public int Tipo { get; set; }
        public string Aseguradora { get; set; }
        public DateTime Fecha { get; set; }
        public string NoPoliza { get; set; }
        public bool? Revisado { get; set; }
        public string UrlPoliza { get; set; }

        public virtual TipoPoliza TipoNavigation { get; set; }
        public virtual Usuario UsernameNavigation { get; set; }
    }
}
