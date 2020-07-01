using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Pyme
    {
        public string NoPoliza { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public string Giro { get; set; }
        public string Subgiro { get; set; }
        public string TipoTecho { get; set; }
        public string TipoMuro { get; set; }
        public int CantidadNiveles { get; set; }
        public string CercaMar { get; set; }

        public virtual Polizas NoPolizaNavigation { get; set; }
    }
}
