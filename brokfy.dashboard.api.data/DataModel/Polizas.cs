using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Polizas
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

        public virtual Aseguradoras IdAseguradorasNavigation { get; set; }
        public virtual Productos Producto { get; set; }
        public virtual TipoPoliza TipoPolizaNavigation { get; set; }
        public virtual Usuario UsernameNavigation { get; set; }
        public virtual Auto Auto { get; set; }
    }
}
