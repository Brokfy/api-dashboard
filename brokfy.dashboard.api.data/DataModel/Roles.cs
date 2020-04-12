using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Roles
    {
        public Roles()
        {
            UsuariosToRoles = new HashSet<UsuariosToRoles>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<UsuariosToRoles> UsuariosToRoles { get; set; }
    }
}
