using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasHogar
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public int TipoRespuesta { get; set; }
    }
}
