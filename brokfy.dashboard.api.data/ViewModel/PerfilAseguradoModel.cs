using brokfy.dashboard.api.data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class PerfilAseguradoModel
    {
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
        //public string EstadoCivil { get; set; }
        public string Profesion { get; set; }
    }

    
}
