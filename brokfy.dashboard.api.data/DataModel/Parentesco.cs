using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Parentesco
    {
        public Parentesco()
        {
            BeneficiariosVida = new HashSet<BeneficiariosVida>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<BeneficiariosVida> BeneficiariosVida { get; set; }
    }
}
