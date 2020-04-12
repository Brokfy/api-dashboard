using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PolizasGastosMedicos
    {
        public string Username { get; set; }
        public string NoPoliza { get; set; }
        public string TipoPoliza { get; set; }

        public virtual Usuario UsernameNavigation { get; set; }
    }
}
