using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class TipoSeguro
    {
        public TipoSeguro()
        {
            Preguntas = new HashSet<Preguntas>();
        }

        public int Id { get; set; }
        public string Seguro { get; set; }

        public virtual ICollection<Preguntas> Preguntas { get; set; }
    }
}
