using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasChat
    {
        public string Pregunta { get; set; }
        public int? Id { get; set; }
        public int? IdHogar { get; set; }
        public int IdPregunta { get; set; }
        public int? IdVida { get; set; }

        public virtual ChatHogar IdHogarNavigation { get; set; }
        public virtual ChatAutomoviles IdNavigation { get; set; }
        public virtual ChatVida IdVidaNavigation { get; set; }
    }
}
