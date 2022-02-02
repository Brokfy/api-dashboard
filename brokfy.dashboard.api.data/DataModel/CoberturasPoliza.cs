using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class CoberturasPoliza
    {
        public string NoPoliza { get; set; }
        public string Cobertura { get; set; }
        public string Deducible { get; set; }
        public string SumaAsegurada { get; set; }

        public virtual Polizas NoPolizaNavigation { get; set; }
    }
}
