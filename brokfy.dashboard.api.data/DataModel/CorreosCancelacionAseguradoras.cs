using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class CorreosCancelacionAseguradoras
    {
        public int IdAseguradora { get; set; }
        public string Correo { get; set; }
        public string Copia { get; set; }

        public virtual Aseguradoras IdAseguradoraNavigation { get; set; }
    }
}
