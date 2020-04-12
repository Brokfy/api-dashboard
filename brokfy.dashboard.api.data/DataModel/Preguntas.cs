using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Preguntas
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public int TipoSeguroId { get; set; }

        public virtual TipoSeguro TipoSeguro { get; set; }
    }
}
