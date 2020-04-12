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
            PerfilAseguradoToSalud = new HashSet<PerfilAseguradoToSalud>();
        }

        public string IdPerfil { get; set; }
        public string Municipio { get; set; }
        public string CodigoPostal { get; set; }
        public string Estado { get; set; }
        public string Hijos { get; set; }
        public string Edad { get; set; }
        public string RegimenVivienda { get; set; }
        public string SituacionLaboral { get; set; }
        public byte Hipoteca { get; set; }
        public byte Viaja { get; set; }
        public byte Mascotas { get; set; }
        public string EstadoCivil { get; set; }
        public int IdProfesion { get; set; }

        public virtual Usuario IdPerfilNavigation { get; set; }
        public virtual Profesiones IdProfesionNavigation { get; set; }
        public virtual ICollection<PerfilAseguradoTieneGadgets> PerfilAseguradoTieneGadgets { get; set; }
        public virtual ICollection<PerfilAseguradoToActividades> PerfilAseguradoToActividades { get; set; }
        public virtual ICollection<PerfilAseguradoToSalud> PerfilAseguradoToSalud { get; set; }
    }
}
