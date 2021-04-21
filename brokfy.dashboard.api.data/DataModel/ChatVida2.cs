using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ChatVida2
    {
        public ChatVida2()
        {
            OpcionesChat = new HashSet<OpcionesChat>();
            PreguntasChatVida = new HashSet<PreguntasChatVida>();
        }

        public int Id { get; set; }

        public virtual ICollection<OpcionesChat> OpcionesChat { get; set; }
        public virtual ICollection<PreguntasChatVida> PreguntasChatVida { get; set; }
    }
}
