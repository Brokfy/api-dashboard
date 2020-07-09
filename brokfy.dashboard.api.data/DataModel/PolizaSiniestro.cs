using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PolizaSiniestro
    {
        public PolizaSiniestro()
        {
            SeguimientoSiniestro = new HashSet<SeguimientoSiniestro>();
        }

        public int IdPolizaSiniestro { get; set; }
        public string NoPoliza { get; set; }
        public DateTime FechaSiniestro { get; set; }
        public int Activo { get; set; }

        public virtual Polizas NoPolizaNavigation { get; set; }
        public virtual ICollection<SeguimientoSiniestro> SeguimientoSiniestro { get; set; }
    }
}
