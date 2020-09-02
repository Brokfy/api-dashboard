using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ChatBienvenida
    {
        public ChatBienvenida()
        {
            OpcionesChat = new HashSet<OpcionesChat>();
            PreguntasBienvenida = new HashSet<PreguntasBienvenida>();
        }

        public long Id { get; set; }

        public virtual ICollection<OpcionesChat> OpcionesChat { get; set; }
        public virtual ICollection<PreguntasBienvenida> PreguntasBienvenida { get; set; }
    }
}
