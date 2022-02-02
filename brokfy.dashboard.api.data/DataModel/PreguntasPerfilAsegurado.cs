using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasPerfilAsegurado
    {
        public PreguntasPerfilAsegurado()
        {
            OpcionesPerfilAsegurado2 = new HashSet<OpcionesPerfilAsegurado2>();
        }

        public long Id { get; set; }
        public string Pregunta { get; set; }
        public int Seccion { get; set; }
        public bool RespuestaMultiple { get; set; }
        public string Titulo { get; set; }
        public string SabiasQue { get; set; }
        public int Omitir { get; set; }

        public virtual ICollection<OpcionesPerfilAsegurado2> OpcionesPerfilAsegurado2 { get; set; }
    }
}
