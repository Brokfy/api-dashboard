using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Marcas
    {
        public Marcas()
        {
            ModelosAseguradoras = new HashSet<ModelosAseguradoras>();
        }

        public long Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual ICollection<ModelosAseguradoras> ModelosAseguradoras { get; set; }
    }
}
