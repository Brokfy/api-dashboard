using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Aseguradoras
    {
        public Aseguradoras()
        {
            AseguradorasComisiones = new HashSet<AseguradorasComisiones>();
            Cancelaciones = new HashSet<Cancelaciones>();
            CartasNombramiento = new HashSet<CartasNombramiento>();
            Pagos = new HashSet<Pagos>();
            Polizas = new HashSet<Polizas>();
            Productos = new HashSet<Productos>();
        }

        public int IdAseguradora { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Enabled { get; set; }
        public string CveCopsis { get; set; }

        public virtual ICollection<AseguradorasComisiones> AseguradorasComisiones { get; set; }
        public virtual ICollection<Cancelaciones> Cancelaciones { get; set; }
        public virtual ICollection<CartasNombramiento> CartasNombramiento { get; set; }
        public virtual ICollection<Pagos> Pagos { get; set; }
        public virtual ICollection<Polizas> Polizas { get; set; }
        public virtual ICollection<Productos> Productos { get; set; }
    }
}
