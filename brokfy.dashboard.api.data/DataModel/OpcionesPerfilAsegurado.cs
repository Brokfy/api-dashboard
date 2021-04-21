using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class OpcionesPerfilAsegurado
    {
        public int Id { get; set; }
        public string Opcion { get; set; }
        public int? Action { get; set; }
        public int IdPreguntaPerfil { get; set; }

        public virtual PreguntasPerfil IdPreguntaPerfilNavigation { get; set; }
    }
}
