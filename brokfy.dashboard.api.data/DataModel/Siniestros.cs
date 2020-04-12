using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Siniestros
    {
        public int IdSiniestros { get; set; }
        public string NoSiniestro { get; set; }
        public string Tipo { get; set; }
        public string Username { get; set; }

        public virtual Usuario UsernameNavigation { get; set; }
    }
}
