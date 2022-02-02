using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class NumeroAsegurado
    {
        public int IdAseguradora { get; set; }
        public string NumAsegurado { get; set; }
        public string Username { get; set; }

        public virtual Aseguradoras IdAseguradoraNavigation { get; set; }
    }
}
