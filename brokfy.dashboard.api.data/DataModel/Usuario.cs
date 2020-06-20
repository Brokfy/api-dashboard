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
            PolizasGastosMedicos = new HashSet<PolizasGastosMedicos>();
            PolizasMascotas = new HashSet<PolizasMascotas>();
            PolizasRc = new HashSet<PolizasRc>();
            PolizasVida = new HashSet<PolizasVida>();
            RestriccionesUsuarioMenu = new HashSet<RestriccionesUsuarioMenu>();
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
        public virtual ICollection<PolizasGastosMedicos> PolizasGastosMedicos { get; set; }
        public virtual ICollection<PolizasMascotas> PolizasMascotas { get; set; }
        public virtual ICollection<PolizasRc> PolizasRc { get; set; }
        public virtual ICollection<PolizasVida> PolizasVida { get; set; }
        public virtual ICollection<RestriccionesUsuarioMenu> RestriccionesUsuarioMenu { get; set; }
        public virtual ICollection<Siniestros> Siniestros { get; set; }
        public virtual ICollection<UsuariosToRoles> UsuariosToRoles { get; set; }
    }
}
