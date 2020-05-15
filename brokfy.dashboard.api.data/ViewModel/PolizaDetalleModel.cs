using brokfy.dashboard.api.data.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
        public class PolizaDetalleModel
        {
            public DetallePoliza Poliza { get; set; }
            public Perfil Usuario { get; set; }
            public List<HistoriaPagoPoliza> Pagos { get; set; }
            public Auto Auto { get; set; } 

        //public Moto Moto { get; set; }
        //public Hogar Hogar { get; set; }
        //public Salud Salud { get; set; }
            public Vida Vida { get; set; }
        //public Gadget Gadget { get; set; }
        //public Mascota Mascota { get; set; }
        //public Viaje Viaje { get; set; }
        //public Retiro Retiro { get; set; }
        //public Pyme Pyme { get; set; }
    }

        public class DetallePago
        {
            public string NoPoliza { get; set; }
            public DateTime FechaPago { get; set; }
            public double MontoPago { get; set; }
            public int IdFormaPago { get; set; }
            public string Referencia { get; set; }
        }

        public class DetallePoliza
        {
            [Key]
            public string NoPoliza { get; set; }
            public int TipoPoliza { get; set; }
            public string FormaPago { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
            public int IdAseguradora { get; set; }
            public string NombreAseguradora { get; set; }
            public long ProductoId { get; set; }
            public string NombreProducto { get; set; }
            public string Habilitada { get; set; }
            public string NoAsegurado { get; set; }
            public string PolizaPropia { get; set; }
            public string PolizaPdf { get; set; }
            public string ReciboPdf { get; set; }
            public string RcUsaCanada { get; set; }
            public string CostoPrimerRecibo { get; set; }
            public string CostoRecibosSubsecuentes { get; set; }
            public double PrimaTotal { get; set; }
            public double PrimaNeta { get; set; }
            public double Comision { get; set; }
            public double Pagado { get; set; }
            public int IdEstadoPoliza { get; set; }
        }

        public class HistoriaPagoPoliza
        {
            [Key]
            public string Referencia { get; set; }
            public DateTime Fecha { get; set; }
            public double Monto { get; set; }
            public string FormaPago { get; set; }
            
        }

}
