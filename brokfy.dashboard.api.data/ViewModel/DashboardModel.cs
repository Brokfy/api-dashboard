using brokfy.dashboard.api.data.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class DashboardModel
    {
        public List<Clientes> clientes { get; set; }
        public List<TipoPoliza> tipoPoliza { get; set; }
        public Descargas descargas { get; set; }
        public List<DashboardGraficoModel> grafico { get; set; }
    }

    public class Descargas
    {
        public List<string> URL { get; set; }
    }

    public class Clientes
    {
        public string Nombre { get; set; }
        public string Username { get; set; }
    }
}
