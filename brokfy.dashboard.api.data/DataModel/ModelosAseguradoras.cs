using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ModelosAseguradoras
    {
        public int Id { get; set; }
        public string NomModelo { get; set; }
        public string AnioComercializacion { get; set; }
        public string Marcas { get; set; }
        public string Aseguradora { get; set; }
        public string CodModelo { get; set; }
        public long? CodBrokfy { get; set; }

        public virtual Marcas CodBrokfyNavigation { get; set; }
    }
}
