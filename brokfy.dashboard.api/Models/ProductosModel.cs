using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brokfy.dashboard.api.Models
{
    public class ProductosModel
    {
        public long Id { get; set; }
        public string Producto { get; set; }
        public string Aseguradora { get; set; }
        public string Xml { get; set; }
        public string IdProductos { get; set; }
        public string XmlEmision { get; set; }
    }
}
