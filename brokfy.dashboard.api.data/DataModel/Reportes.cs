using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Reportes
    {
        public int IdReporte { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Path { get; set; }
    }
}
