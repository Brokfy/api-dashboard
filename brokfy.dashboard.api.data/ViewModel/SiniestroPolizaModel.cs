using System;
using System.Collections.Generic;
using System.Text;

namespace brokfy.dashboard.api.data.ViewModel
{
    public class SiniestroPolizaModel
    {
        public int IdPolizaSiniestro { get; set; }
        public string NoPoliza { get; set; }
        public string TipoPoliza { get; set; }
        public string Aseguradora { get; set; }
        public string Username { get; set; }
        public DateTime FechaSiniestro { get; set; }
        public string EstatusSiniestro { get; set; }
    }
}
