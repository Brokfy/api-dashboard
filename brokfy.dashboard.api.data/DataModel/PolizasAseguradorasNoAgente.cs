using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PolizasAseguradorasNoAgente
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UrlPoliza { get; set; }
        public long IdPoliza { get; set; }

        public virtual Usuario UsernameNavigation { get; set; }
    }
}
