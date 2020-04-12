using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class NivelesCondominio
    {
        public int Id { get; set; }
        public int Nivel { get; set; }
        public string ValidadorAfirme { get; set; }
        public string IdAfirme { get; set; }
    }
}
