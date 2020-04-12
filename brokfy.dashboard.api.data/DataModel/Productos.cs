using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Productos
    {
        public Productos()
        {
            Coberturas = new HashSet<Coberturas>();
            Polizas = new HashSet<Polizas>();
        }

        public long Id { get; set; }
        public string Producto { get; set; }
        public int Aseguradora { get; set; }
        public string Xml { get; set; }
        public long IdProductos { get; set; }
        public string XmlEmision { get; set; }

        public virtual Aseguradoras AseguradoraNavigation { get; set; }
        public virtual ProductosBrokfy IdProductosNavigation { get; set; }
        public virtual ICollection<Coberturas> Coberturas { get; set; }
        public virtual ICollection<Polizas> Polizas { get; set; }
    }
}
