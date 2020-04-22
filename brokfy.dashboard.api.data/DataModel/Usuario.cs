using System;
using System.Collections.Generic;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class Usuario
    {
        public Usuario()
        {
            CartasNombramiento = new HashSet<CartasNombramiento>();
            MetodosPagoReg = new HashSet<MetodosPagoReg>();
            Polizas = new HashSet<Polizas>();
            PolizasAseguradorasNoAgente = new HashSet<PolizasAseguradorasNoAgente>();
            PolizasGadgets = new HashSet<PolizasGadgets>();
            PolizasGastosMedicos = new HashSet<PolizasGastosMedicos>();
            PolizasHogar = new HashSet<PolizasHogar>();
            PolizasMascotas = new HashSet<PolizasMascotas>();
            PolizasMoto = new HashSet<PolizasMoto>();
            PolizasRc = new HashSet<PolizasRc>();
            PolizasVida = new HashSet<PolizasVida>();
            Siniestros = new HashSet<Siniestros>();
            UsuariosToRoles = new HashSet<UsuariosToRoles>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool? Enabled { get; set; }
        public int? Intentos { get; set; }
        public string IdConekta { get; set; }
        public string Token { get; set; }
        public string NameAws { get; set; }
        public string TokenF { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual PerfilAsegurado PerfilAsegurado { get; set; }
        public virtual ICollection<CartasNombramiento> CartasNombramiento { get; set; }
        public virtual ICollection<MetodosPagoReg> MetodosPagoReg { get; set; }
        public virtual ICollection<Polizas> Polizas { get; set; }
        public virtual ICollection<PolizasAseguradorasNoAgente> PolizasAseguradorasNoAgente { get; set; }
        public virtual ICollection<PolizasGadgets> PolizasGadgets { get; set; }
        public virtual ICollection<PolizasGastosMedicos> PolizasGastosMedicos { get; set; }
        public virtual ICollection<PolizasHogar> PolizasHogar { get; set; }
        public virtual ICollection<PolizasMascotas> PolizasMascotas { get; set; }
        public virtual ICollection<PolizasMoto> PolizasMoto { get; set; }
        public virtual ICollection<PolizasRc> PolizasRc { get; set; }
        public virtual ICollection<PolizasVida> PolizasVida { get; set; }
        public virtual ICollection<Siniestros> Siniestros { get; set; }
        public virtual ICollection<UsuariosToRoles> UsuariosToRoles { get; set; }
    }
}
