using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PerfilAsegurado
    {
        public PerfilAsegurado()
        {
            PerfilAseguradoTieneGadgets = new HashSet<PerfilAseguradoTieneGadgets>();
            PerfilAseguradoToActividades = new HashSet<PerfilAseguradoToActividades>();
            PerfilAseguradoToPropiedades = new HashSet<PerfilAseguradoToPropiedades>();
            PerfilAseguradoToSalud = new HashSet<PerfilAseguradoToSalud>();
            PolizasPorSubirPerfilAsegurado = new HashSet<PolizasPorSubirPerfilAsegurado>();
        }

        public string IdPerfil { get; set; }
        public string Municipio { get; set; }
        public string CodigoPostal { get; set; }
        public string Estado { get; set; }
        public string Hijos { get; set; }
        public string Edad { get; set; }
        public string RegimenVivienda { get; set; }
        public string SituacionLaboral { get; set; }
        public bool Hipoteca { get; set; }
        public bool Viaja { get; set; }
        public bool Mascotas { get; set; }
        public string EstadoCivil { get; set; }
        public int IdProfesion { get; set; }
        public bool DeportesRiesgo { get; set; }

        public virtual Usuario IdPerfilNavigation { get; set; }
        public virtual Profesiones IdProfesionNavigation { get; set; }
        public virtual ICollection<PerfilAseguradoTieneGadgets> PerfilAseguradoTieneGadgets { get; set; }
        public virtual ICollection<PerfilAseguradoToActividades> PerfilAseguradoToActividades { get; set; }
        public virtual ICollection<PerfilAseguradoToPropiedades> PerfilAseguradoToPropiedades { get; set; }
        public virtual ICollection<PerfilAseguradoToSalud> PerfilAseguradoToSalud { get; set; }
        public virtual ICollection<PolizasPorSubirPerfilAsegurado> PolizasPorSubirPerfilAsegurado { get; set; }
    }
}
