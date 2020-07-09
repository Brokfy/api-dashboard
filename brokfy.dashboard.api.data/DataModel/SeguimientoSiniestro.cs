using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class SeguimientoSiniestro
    {
        public int IdSeguimientoSiniestro { get; set; }
        public int IdPolizaSiniestro { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEstadoSiniestro { get; set; }
        public string Comentario { get; set; }
        public string Username { get; set; }

        public virtual EstadoSiniestro IdEstadoSiniestroNavigation { get; set; }
        public virtual PolizaSiniestro IdPolizaSiniestroNavigation { get; set; }
        public virtual Usuario UsernameNavigation { get; set; }
    }
}
