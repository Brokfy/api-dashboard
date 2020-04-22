using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Bfusers
    {
        public long IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
    }
}
