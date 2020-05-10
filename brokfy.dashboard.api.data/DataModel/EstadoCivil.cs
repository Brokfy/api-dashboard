﻿using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class EstadoCivil
    {
        public EstadoCivil()
        {
            Vida = new HashSet<Vida>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Vida> Vida { get; set; }
    }
}