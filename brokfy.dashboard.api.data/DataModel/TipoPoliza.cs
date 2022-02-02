using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class TipoPoliza
    {
        public TipoPoliza()
        {
            AseguradorasComisiones = new HashSet<AseguradorasComisiones>();
            CartasNombramiento = new HashSet<CartasNombramiento>();
            EstadoSiniestro = new HashSet<EstadoSiniestro>();
            Notificaciones = new HashSet<Notificaciones>();
            Polizas = new HashSet<Polizas>();
            PolizasPorSubir = new HashSet<PolizasPorSubir>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public bool Habilitada { get; set; }

        public virtual ICollection<AseguradorasComisiones> AseguradorasComisiones { get; set; }
        public virtual ICollection<CartasNombramiento> CartasNombramiento { get; set; }
        public virtual ICollection<EstadoSiniestro> EstadoSiniestro { get; set; }
        public virtual ICollection<Notificaciones> Notificaciones { get; set; }
        public virtual ICollection<Polizas> Polizas { get; set; }
        public virtual ICollection<PolizasPorSubir> PolizasPorSubir { get; set; }
    }
}
