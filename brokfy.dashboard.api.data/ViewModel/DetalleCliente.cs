using brokfy.dashboard.api.data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class DetalleCliente
    {
        public List<PolizasModel> Polizas { get; set; }
        public Perfil DatosPersonales { get; set; }
        public PerfilAseguradoModel PerfilAsegurado { get; set; }
    }
}
