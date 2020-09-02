using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasChatHogar
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public int IdChatHogar2 { get; set; }

        public virtual ChatHogar2 IdChatHogar2Navigation { get; set; }
    }
}
