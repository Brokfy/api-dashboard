using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Aseguradoras
    {
        public Aseguradoras()
        {
            Polizas = new HashSet<Polizas>();
            Productos = new HashSet<Productos>();
        }

        public int IdAseguradora { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Enabled { get; set; }
        public string CveCopsis { get; set; }

        public virtual ICollection<Polizas> Polizas { get; set; }
        public virtual ICollection<Productos> Productos { get; set; }
    }
}
