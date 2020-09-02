using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ChatSubirPoliza
    {
        public ChatSubirPoliza()
        {
            OpcionesChat = new HashSet<OpcionesChat>();
            PreguntasSubirPoliza = new HashSet<PreguntasSubirPoliza>();
        }

        public int Id { get; set; }

        public virtual ICollection<OpcionesChat> OpcionesChat { get; set; }
        public virtual ICollection<PreguntasSubirPoliza> PreguntasSubirPoliza { get; set; }
    }
}
