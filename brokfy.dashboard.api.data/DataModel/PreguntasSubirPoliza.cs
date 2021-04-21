using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PreguntasSubirPoliza
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public string Anexos { get; set; }
        public int? IdChatSubirPoliza { get; set; }

        public virtual ChatSubirPoliza IdChatSubirPolizaNavigation { get; set; }
    }
}
