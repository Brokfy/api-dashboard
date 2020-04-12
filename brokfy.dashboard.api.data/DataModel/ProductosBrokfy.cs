using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class ProductosBrokfy
    {
        public ProductosBrokfy()
        {
            Productos = new HashSet<Productos>();
        }

        public long Id { get; set; }
        public string Producto { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
