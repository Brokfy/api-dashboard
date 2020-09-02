using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ChatHogar2
    {
        public ChatHogar2()
        {
            PreguntasChatHogar = new HashSet<PreguntasChatHogar>();
        }

        public int Id { get; set; }

        public virtual ICollection<PreguntasChatHogar> PreguntasChatHogar { get; set; }
    }
}
