using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class MetodosPagoReg
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Defecto { get; set; }

        public virtual Usuario UsernameNavigation { get; set; }
    }
}
