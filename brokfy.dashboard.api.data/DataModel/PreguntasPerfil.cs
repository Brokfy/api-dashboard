using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasPerfil
    {
        public PreguntasPerfil()
        {
            OpcionesPerfilAsegurado = new HashSet<OpcionesPerfilAsegurado>();
            PreguntasPerfilToPerfiilAsegurado = new HashSet<PreguntasPerfilToPerfiilAsegurado>();
        }

        public int Id { get; set; }
        public string Pregunta { get; set; }
        public int Seccion { get; set; }
        public bool RespuestaMultiple { get; set; }

        public virtual ICollection<OpcionesPerfilAsegurado> OpcionesPerfilAsegurado { get; set; }
        public virtual ICollection<PreguntasPerfilToPerfiilAsegurado> PreguntasPerfilToPerfiilAsegurado { get; set; }
    }
}
