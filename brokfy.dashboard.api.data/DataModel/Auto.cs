using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Auto
    {
        public Auto()
        {
            Notificaciones = new HashSet<Notificaciones>();
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string NoPoliza { get; set; }
        public string Placas { get; set; }
        public string Clave { get; set; }
        public string CodigoPostal { get; set; }

        public virtual Polizas NoPolizaNavigation { get; set; }
        public virtual ICollection<Notificaciones> Notificaciones { get; set; }
    }
}
