using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brokfy.dashboard.api.Models
{
    public class PostDetallePerfilAseguradoModel
    {
        public string Username { get; set; }
        public string Modulo { get; set; }
        public int IdDetalle { get; set; }
        public bool Aplica { get; set; }
    }
}
