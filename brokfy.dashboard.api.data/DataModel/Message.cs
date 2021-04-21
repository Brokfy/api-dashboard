using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Message
    {
        public string Username { get; set; }
        public string MessageId { get; set; }

        public virtual Usuario UsernameNavigation { get; set; }
    }
}
