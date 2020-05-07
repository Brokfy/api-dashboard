using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class BeneficiariosVida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Curp { get; set; }
        public string PctAsignado { get; set; }
        public int IdParentesco { get; set; }
        public string NoPoliza { get; set; }

        public virtual Parentesco IdParentescoNavigation { get; set; }
        public virtual Vida NoPolizaNavigation { get; set; }
    }
}
