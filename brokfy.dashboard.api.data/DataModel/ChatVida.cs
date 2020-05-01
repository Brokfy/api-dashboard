using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ChatVida
    {
        public ChatVida()
        {
            PreguntasChat = new HashSet<PreguntasChat>();
        }

        public int Id { get; set; }
        public string TipoRespuesta { get; set; }

        public virtual ICollection<PreguntasChat> PreguntasChat { get; set; }
    }
}
