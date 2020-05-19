using brokfy.dashboard.api.data.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class DetalleCliente
    {
        public List<Polizas> Polizas { get; set; }
        public List<Pagos> Pagos { get; set; }
        public Perfil DatosPerfonales { get; set; }
        public PerfilAsegurado Perfil { get; set; }
    }
}
