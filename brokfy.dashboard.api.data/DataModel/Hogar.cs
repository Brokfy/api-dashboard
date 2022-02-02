using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Hogar
    {
        public Hogar()
        {
            Notificaciones = new HashSet<Notificaciones>();
        }

        public string NoPoliza { get; set; }
        public int IdTipoVivienda { get; set; }
        public int IdTipoTecho { get; set; }
        public int IdTipoMuro { get; set; }
        public int? Piso { get; set; }
        public int? NoPisosCondominio { get; set; }
        public int? Sotanos { get; set; }
        public int? NivelesCasa { get; set; }
        public bool FrenteMar { get; set; }

        public virtual Polizas NoPolizaNavigation { get; set; }
        public virtual ICollection<Notificaciones> Notificaciones { get; set; }
    }
}
