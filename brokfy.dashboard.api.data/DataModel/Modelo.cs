using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Modelo
    {
        public Modelo()
        {
            InverseIdMarcaNavigation = new HashSet<Modelo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdMarca { get; set; }

        public virtual Modelo IdMarcaNavigation { get; set; }
        public virtual ICollection<Modelo> InverseIdMarcaNavigation { get; set; }
    }
}
