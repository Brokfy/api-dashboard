﻿using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class TipoPoliza
    {
        public TipoPoliza()
        {
            CartasNombramiento = new HashSet<CartasNombramiento>();
            Polizas = new HashSet<Polizas>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<CartasNombramiento> CartasNombramiento { get; set; }
        public virtual ICollection<Polizas> Polizas { get; set; }
    }
}