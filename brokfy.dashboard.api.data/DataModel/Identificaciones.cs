using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Identificaciones
    {
        public string Username { get; set; }
        public string FotoDelantera { get; set; }
        public string FotoTrasera { get; set; }
        public string Tipo { get; set; }

        public virtual Usuario UsernameNavigation { get; set; }
    }
}
