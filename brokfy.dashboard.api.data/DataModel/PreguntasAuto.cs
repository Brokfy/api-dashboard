using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasAuto
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public long IdChatAuto { get; set; }

        public virtual ChatAuto IdChatAutoNavigation { get; set; }
    }
}
