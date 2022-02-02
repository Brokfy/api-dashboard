using brokfy.dashboard.api.data.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class PolizaVida
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
        public bool Fumador { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
        public string Ingresos { get; set; }
        public int IdOcupacion { get; set; }
        public int IdEstadoCivil { get; set; }
        public int IdSexo { get; set; }
        public int IdEstadoPoliza { get; set; }
        public List<BeneficiariosVida> Beneficiarios { get; set; }

        public string fullName { get; set; }
    }
}
