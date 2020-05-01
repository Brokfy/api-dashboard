using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class CartasNombramiento
    {
        public string Username { get; set; }
        public int Tipo { get; set; }
        public int Aseguradora { get; set; }
        public DateTime Fecha { get; set; }
        public string NoPoliza { get; set; }
        public bool? Revisado { get; set; }
        public string UrlPoliza { get; set; }
        public string UrlCartaNombramiento { get; set; }
        public bool Firmada { get; set; }

        public virtual Aseguradoras AseguradoraNavigation { get; set; }
        public virtual TipoPoliza TipoNavigation { get; set; }
        public virtual Usuario UsernameNavigation { get; set; }
    }
}
