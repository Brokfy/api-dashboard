using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string NoPoliza { get; set; }
        public string Placas { get; set; }
        public string Clave { get; set; }

        public virtual Polizas NoPolizaNavigation { get; set; }
    }
}
