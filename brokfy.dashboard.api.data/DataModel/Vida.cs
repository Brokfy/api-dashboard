using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Vida
    {
        public Vida()
        {
            BeneficiariosVida = new HashSet<BeneficiariosVida>();
        }

        public string NoPoliza { get; set; }
        public bool Fumador { get; set; }
        public string Estatura { get; set; }
        public string Peso { get; set; }
        public string Ingresos { get; set; }
        public int IdOcupacion { get; set; }
        public int IdEstadoCivil { get; set; }
        public int IdSexo { get; set; }

        public virtual EstadoCivil IdEstadoCivilNavigation { get; set; }
        public virtual Ocupaciones IdOcupacionNavigation { get; set; }
        public virtual Sexo IdSexoNavigation { get; set; }
        public virtual Polizas NoPolizaNavigation { get; set; }
        public virtual ICollection<BeneficiariosVida> BeneficiariosVida { get; set; }
    }
}
