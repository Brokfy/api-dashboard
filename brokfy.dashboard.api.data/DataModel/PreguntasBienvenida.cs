using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasBienvenida
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public long IdChatBienvenida { get; set; }

        public virtual ChatBienvenida IdChatBienvenidaNavigation { get; set; }
    }
}
