using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class OpcionesPerfilAsegurado2
    {
        public int Id { get; set; }
        public string Opcion { get; set; }
        public int? Action { get; set; }
        public long IdPreguntaPerfilAsegurado { get; set; }

        public virtual PreguntasPerfilAsegurado IdPreguntaPerfilAseguradoNavigation { get; set; }
    }
}
