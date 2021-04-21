using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Notificaciones
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Titulo { get; set; }
        public string Body { get; set; }
        public DateTime Fecha { get; set; }
        public int? TipoPoliza { get; set; }
        public bool Leido { get; set; }
        public string NoPolizaAuto { get; set; }
        public string NoPolizaHogar { get; set; }

        public virtual Auto NoPolizaAutoNavigation { get; set; }
        public virtual Hogar NoPolizaHogarNavigation { get; set; }
        public virtual TipoPoliza TipoPolizaNavigation { get; set; }
        public virtual Usuario UsernameNavigation { get; set; }
    }
}
