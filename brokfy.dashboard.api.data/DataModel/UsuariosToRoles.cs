using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class UsuariosToRoles
    {
        public string UsuarioId { get; set; }
        public int RoleId { get; set; }

        public virtual Roles Role { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
