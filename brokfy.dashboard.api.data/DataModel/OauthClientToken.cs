using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class OauthClientToken
    {
        public string TokenId { get; set; }
        public byte[] Token { get; set; }
        public string AuthenticationId { get; set; }
        public string UserName { get; set; }
        public string ClientId { get; set; }
    }
}
