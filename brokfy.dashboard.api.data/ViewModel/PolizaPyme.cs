using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class PolizaPyme
    {
        public int TipoPoliza { get; set; }
        public double Costo { get; set; }
        public string NoPoliza { get; set; }
        public string FormaPago { get; set; }
        public DateTime ProximoPago { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdAseguradoras { get; set; }
        public string Username { get; set; }
        public long ProductoId { get; set; }
        public string Habilitada { get; set; }
        public string NoAsegurado { get; set; }
        public string PolizaPropia { get; set; }
        public string PolizaPdf { get; set; }
        public string ReciboPdf { get; set; }
        public string RcUsaCanada { get; set; }
        public string CostoPrimerRecibo { get; set; }
        public string CostoRecibosSubsecuentes { get; set; }
        public double PrimaNeta { get; set; }
        public int IdEstadoPoliza { get; set; }
        public string RazonSocial { get; set; }
        public string Rfc { get; set; }
        public string Giro { get; set; }
        public string Subgiro { get; set; }
        public string TipoTecho { get; set; }
        public string TipoMuro { get; set; }
        public int CantidadNiveles { get; set; }
        public string CercaMar { get; set; }
    }
}
