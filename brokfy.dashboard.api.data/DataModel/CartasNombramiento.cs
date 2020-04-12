using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class CartasNombramiento
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Tipo { get; set; }
        public string Aseguradora { get; set; }
        public DateTime Fecha { get; set; }
        public string NoPoliza { get; set; }

        public virtual Usuario UsernameNavigation { get; set; }
    }
}
