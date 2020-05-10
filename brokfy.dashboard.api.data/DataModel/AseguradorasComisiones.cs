using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class AseguradorasComisiones
    {
        public int Id { get; set; }
        public int IdAseguradora { get; set; }
        public int IdTipoPoliza { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public double Valor { get; set; }

        public virtual Aseguradoras IdAseguradoraNavigation { get; set; }
        public virtual TipoPoliza IdTipoPolizaNavigation { get; set; }
    }
}
