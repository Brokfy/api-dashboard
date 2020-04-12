using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class UsoVivienda
    {
        public int Id { get; set; }
        public string Etiqueta { get; set; }
        public string Validador { get; set; }
        public string Valor { get; set; }
        public string IdAfirme { get; set; }
    }
}
