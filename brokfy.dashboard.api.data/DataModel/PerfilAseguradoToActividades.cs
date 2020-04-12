using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PerfilAseguradoToActividades
    {
        public string IdPerfil { get; set; }
        public int IdActividad { get; set; }
        public byte? Seguro { get; set; }

        public virtual Actividades IdActividadNavigation { get; set; }
        public virtual PerfilAsegurado IdPerfilNavigation { get; set; }
    }
}
