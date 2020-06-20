using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class RestriccionesUsuarioMenu
    {
        public string Username { get; set; }
        public int IdMenu { get; set; }

        public virtual Menu IdMenuNavigation { get; set; }
        public virtual Usuario UsernameNavigation { get; set; }
    }
}
