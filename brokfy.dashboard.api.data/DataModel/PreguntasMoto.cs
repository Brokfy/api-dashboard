using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasMoto
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public int IdChatMoto { get; set; }

        public virtual ChatMoto IdChatMotoNavigation { get; set; }
    }
}
