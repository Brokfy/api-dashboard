using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PolizasMoto
    {
        public string Username { get; set; }
        public string NoPoliza { get; set; }

        public virtual Usuario UsernameNavigation { get; set; }
    }
}
