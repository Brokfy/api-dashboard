using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Descargables
    {
        public int IdDescargable { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public int Orden { get; set; }
    }
}
