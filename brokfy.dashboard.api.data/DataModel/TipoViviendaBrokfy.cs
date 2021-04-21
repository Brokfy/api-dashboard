using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class TipoViviendaBrokfy
    {
        public TipoViviendaBrokfy()
        {
            Hogar = new HashSet<Hogar>();
        }

        public int Id { get; set; }
        public string Etiqueta { get; set; }
        public string IdAfirme { get; set; }
        public string IdChubb { get; set; }
        public string ValorAfirme { get; set; }
        public string ValidadorAfirme { get; set; }

        public virtual ICollection<Hogar> Hogar { get; set; }
    }
}
