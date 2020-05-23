using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Cancelaciones
    {
        public string NoPoliza { get; set; }
        public int IdAseguradora { get; set; }
        public string Rfc { get; set; }
        public string UrlCartaCancelacion { get; set; }

        public virtual Aseguradoras IdAseguradoraNavigation { get; set; }
        public virtual Polizas NoPolizaNavigation { get; set; }
    }
}
