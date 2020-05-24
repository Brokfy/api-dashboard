using brokfy.dashboard.api.data.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class DetalleCliente
    {
        public List<Polizas> Polizas { get; set; }
        public Perfil DatosPersonales { get; set; }
        public PerfilAsegurado PerfilAsegurado { get; set; }
    }
}
