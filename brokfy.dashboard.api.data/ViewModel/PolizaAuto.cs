using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class PolizaAuto
    {
        [Key]
        public string NoPoliza { get; set; }
        public string FormaPago { get; set; }
        public DateTime ProximoPago { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdAseguradoras { get; set; }
        public double Costo { get; set; }
        public double PrimaNeta { get; set; }
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
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placas { get; set; }
        public string Clave { get; set; }
        public string CodigoPostal { get; set; }
        public int IdEstadoPoliza { get; set; }
    }
}
