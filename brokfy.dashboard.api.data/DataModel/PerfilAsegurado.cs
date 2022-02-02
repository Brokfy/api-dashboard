using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PerfilAsegurado
    {
        public PerfilAsegurado()
        {
            PerfilAseguradoHijosAsegurados = new HashSet<PerfilAseguradoHijosAsegurados>();
            PerfilAseguradoSegurosPareja = new HashSet<PerfilAseguradoSegurosPareja>();
            PerfilAseguradoVehiculos = new HashSet<PerfilAseguradoVehiculos>();
            PolizasPorSubir = new HashSet<PolizasPorSubir>();
            PolizasPorSubirPerfilAsegurado = new HashSet<PolizasPorSubirPerfilAsegurado>();
            PreguntasPerfilToPerfiilAsegurado = new HashSet<PreguntasPerfilToPerfiilAsegurado>();
        }

        public string IdPerfil { get; set; }
        public bool Gmm { get; set; }
        public bool DeportesRiesgo { get; set; }
        public bool SeguroVida { get; set; }
        public string Hijos { get; set; }
        public bool Casado { get; set; }
        public bool Viaja { get; set; }
        public bool SeguroViaje { get; set; }
        public bool SeguroRetiro { get; set; }
        public string RegimenVivienda { get; set; }
        public bool Empresario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool? SeguroPyme { get; set; }
        public bool? SeguroHogar { get; set; }
        public bool? SeguroAccidente { get; set; }

        public virtual ICollection<PerfilAseguradoHijosAsegurados> PerfilAseguradoHijosAsegurados { get; set; }
        public virtual ICollection<PerfilAseguradoSegurosPareja> PerfilAseguradoSegurosPareja { get; set; }
        public virtual ICollection<PerfilAseguradoVehiculos> PerfilAseguradoVehiculos { get; set; }
        public virtual ICollection<PolizasPorSubir> PolizasPorSubir { get; set; }
        public virtual ICollection<PolizasPorSubirPerfilAsegurado> PolizasPorSubirPerfilAsegurado { get; set; }
        public virtual ICollection<PreguntasPerfilToPerfiilAsegurado> PreguntasPerfilToPerfiilAsegurado { get; set; }
    }
}
