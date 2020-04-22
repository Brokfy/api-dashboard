using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class OauthRefreshToken
    {
        public string TokenId { get; set; }
        public byte[] Token { get; set; }
        public byte[] Authentication { get; set; }
    }
}
