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
        public double PrimaAnual { get; set; }
        public double PrimaNeta { get; set; }
        public double ImportePagoFraccionado { get; set; }
        public double PrimaDelRecibo { get; set; }
        public string Version { get; set; }
    }
}
