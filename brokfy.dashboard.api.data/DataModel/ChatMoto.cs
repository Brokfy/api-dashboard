using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ChatMoto
    {
        public ChatMoto()
        {
            OpcionesChat = new HashSet<OpcionesChat>();
            PreguntasMoto = new HashSet<PreguntasMoto>();
        }

        public int Id { get; set; }

        public virtual ICollection<OpcionesChat> OpcionesChat { get; set; }
        public virtual ICollection<PreguntasMoto> PreguntasMoto { get; set; }
    }
}
