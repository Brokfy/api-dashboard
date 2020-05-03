using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brokfy.dashboard.api.Models
{
    public class CartaNombramientoShowModel
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public int Tipo { get; set; }
        public int Aseguradora { get; set; }
        public DateTime Fecha { get; set; }
        public string NoPoliza { get; set; }
        public bool? Revisado { get; set; }
        public string UrlPoliza { get; set; }
        public string UrlCartaNombramiento { get; set; }
        public bool Firmada { get; set; }
    }
}
