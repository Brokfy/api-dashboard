﻿using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class PerfilAseguradoHijosAsegurados
    {
        public string IdPerfil { get; set; }
        public string Seguro { get; set; }

        public virtual PerfilAsegurado IdPerfilNavigation { get; set; }
    }
}