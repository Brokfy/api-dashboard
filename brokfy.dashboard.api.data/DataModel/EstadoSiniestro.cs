﻿using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class EstadoSiniestro
    {
        public EstadoSiniestro()
        {
            SeguimientoSiniestro = new HashSet<SeguimientoSiniestro>();
        }

        public int IdEstadoSiniestro { get; set; }
        public string Nombre { get; set; }
        public int Activo { get; set; }
        public int IdTipoPoliza { get; set; }
        public int Orden { get; set; }

        public virtual TipoPoliza IdTipoPolizaNavigation { get; set; }
        public virtual ICollection<SeguimientoSiniestro> SeguimientoSiniestro { get; set; }
    }
}
