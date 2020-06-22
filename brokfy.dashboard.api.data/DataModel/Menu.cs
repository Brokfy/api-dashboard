using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Menu
    {
        public Menu()
        {
            InverseIdMenuPadreNavigation = new HashSet<Menu>();
            RestriccionesUsuarioMenu = new HashSet<RestriccionesUsuarioMenu>();
        }

        public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public string Ruta { get; set; }
        public string Icono { get; set; }
        public int? IdMenuPadre { get; set; }

        public virtual Menu IdMenuPadreNavigation { get; set; }
        public virtual ICollection<Menu> InverseIdMenuPadreNavigation { get; set; }
        public virtual ICollection<RestriccionesUsuarioMenu> RestriccionesUsuarioMenu { get; set; }
    }
}
