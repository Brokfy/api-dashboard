using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ChatHogar
    {
        public ChatHogar()
        {
            PreguntasChat = new HashSet<PreguntasChat>();
        }

        public int Id { get; set; }
        public int TipoRespuesta { get; set; }

        public virtual ICollection<PreguntasChat> PreguntasChat { get; set; }
    }
}
