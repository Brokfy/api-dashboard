using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class OauthCode
    {
        public string Code { get; set; }
        public byte[] Authentication { get; set; }
    }
}
