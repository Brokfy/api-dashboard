using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class OpcionesChat
    {
        public int Id { get; set; }
        public string Opcion { get; set; }
        public string Endpoint { get; set; }
        public string Valor { get; set; }
        public string Action { get; set; }
        public string Url { get; set; }
        public long? IdChatBienvenida { get; set; }
        public long? IdChatAuto { get; set; }
        public int? IdChatSubirPoliza { get; set; }
        public int? IdChatHogar2 { get; set; }
        public int? IdChatVida2 { get; set; }
        public int? IdChatMoto { get; set; }

        public virtual ChatAuto IdChatAutoNavigation { get; set; }
        public virtual ChatBienvenida IdChatBienvenidaNavigation { get; set; }
        public virtual ChatHogar2 IdChatHogar2Navigation { get; set; }
        public virtual ChatMoto IdChatMotoNavigation { get; set; }
        public virtual ChatSubirPoliza IdChatSubirPolizaNavigation { get; set; }
        public virtual ChatVida2 IdChatVida2Navigation { get; set; }
    }
}
