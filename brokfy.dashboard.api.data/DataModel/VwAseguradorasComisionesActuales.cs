using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class VwAseguradorasComisionesActuales
    {
        public int IdAseguradora { get; set; }
        public double? Auto { get; set; }
        public double? Moto { get; set; }
        public double? Hogar { get; set; }
        public double? Salud { get; set; }
        public double? Vida { get; set; }
        public double? Gadget { get; set; }
        public double? Mascota { get; set; }
        public double? Viaje { get; set; }
        public double? Retiro { get; set; }
        public double? Pyme { get; set; }
    }
}
