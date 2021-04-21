using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasChatVida
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public int IdChatVida { get; set; }

        public virtual ChatVida2 IdChatVidaNavigation { get; set; }
    }
}
