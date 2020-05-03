using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brokfy.dashboard.api.Models
{
    public class CascadaAseguradoraProductos
    {
        public int IdAseguradora { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Enabled { get; set; }
        public string CveCopsis { get; set; }
        public long Id { get; set; }
        public string Producto { get; set; }
        public int Aseguradora { get; set; }
        public string Xml { get; set; }
        public long IdProductos { get; set; }
        public string XmlEmision { get; set; }
    }
}
