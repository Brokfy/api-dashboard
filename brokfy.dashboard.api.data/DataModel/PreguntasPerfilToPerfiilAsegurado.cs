using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasPerfilToPerfiilAsegurado
    {
        public int PreguntasPerfilId { get; set; }
        public string PerfilAseguradoId { get; set; }

        public virtual PerfilAsegurado PerfilAsegurado { get; set; }
        public virtual PreguntasPerfil PreguntasPerfil { get; set; }
    }
}
