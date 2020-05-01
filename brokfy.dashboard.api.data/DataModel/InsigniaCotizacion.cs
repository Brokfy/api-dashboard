using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class InsigniaCotizacion
    {
        public int Id { get; set; }
        public string Edad { get; set; }
        public string SumaSeleccionada { get; set; }
        public string GeneroTitular { get; set; }
        public string Frecuencia { get; set; }
        public bool Fumador { get; set; }
        public string PrimaAnual { get; set; }
        public string PrimaFraccionada { get; set; }
        public string SumaAsegurada { get; set; }
    }
}
