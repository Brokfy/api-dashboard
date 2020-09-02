using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ChatAuto
    {
        public ChatAuto()
        {
            OpcionesChat = new HashSet<OpcionesChat>();
            PreguntasAuto = new HashSet<PreguntasAuto>();
        }

        public long Id { get; set; }

        public virtual ICollection<OpcionesChat> OpcionesChat { get; set; }
        public virtual ICollection<PreguntasAuto> PreguntasAuto { get; set; }
    }
}
