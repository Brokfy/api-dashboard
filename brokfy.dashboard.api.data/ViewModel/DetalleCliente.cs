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
        public DetallePerfilAsegurado DetallePerfil { get; set; }
    }

    public class DetallePerfilAsegurado
    {
        public List<DescripcionValor> Gadgets { get; set; }
        public List<DescripcionValor> Actividades { get; set; }
        public List<DescripcionValor> Propiedades { get; set; }
        public List<DescripcionValor> Salud { get; set; }
    }

    public class DescripcionValor 
    { 
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Aplica { get; set; }
    }
}
