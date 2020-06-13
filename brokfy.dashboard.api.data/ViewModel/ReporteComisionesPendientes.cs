﻿using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class ReporteComisionesPendientes
    {
        public int TipoRegistro { get; set; }
        public string Aseguradora { get; set; }
        public string TipoPoliza { get; set; }
        public DateTime? FechaPago { get; set; }
        public string NumeroPoliza { get; set; }
        public string Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public double? MontoComision { get; set; }
        public double? MontoPagado { get; set; }
        public double? MontoPendiente { get; set; }
    }
}