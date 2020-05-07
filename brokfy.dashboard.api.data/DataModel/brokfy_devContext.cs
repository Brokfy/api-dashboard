using System;
using brokfy.dashboard.api.data.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace brokfy.dashboard.api.data.DataModel
{
    public partial class brokfy_devContext : DbContext
    {
        public brokfy_devContext()
        {
        }

        public brokfy_devContext(DbContextOptions<brokfy_devContext> options)
            : base(options)
        {
        }
        public virtual DbSet<PolizaAuto> PolizaAutos { get; set; }
        public virtual DbSet<PolizaVida> PolizaVidas { get; set; }
        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<AnosMarca> AnosMarca { get; set; }
        public virtual DbSet<Aseguradoras> Aseguradoras { get; set; }
        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Bankcode> Bankcode { get; set; }
        public virtual DbSet<BeneficiariosVida> BeneficiariosVida { get; set; }
        public virtual DbSet<Bfroles> Bfroles { get; set; }
        public virtual DbSet<Bfroleusers> Bfroleusers { get; set; }
        public virtual DbSet<Bfusers> Bfusers { get; set; }
        public virtual DbSet<CartasNombramiento> CartasNombramiento { get; set; }
        public virtual DbSet<CatalogoHomologado> CatalogoHomologado { get; set; }
        public virtual DbSet<ChatAutomoviles> ChatAutomoviles { get; set; }
        public virtual DbSet<ChatHogar> ChatHogar { get; set; }
        public virtual DbSet<ChatVida> ChatVida { get; set; }
        public virtual DbSet<Coberturas> Coberturas { get; set; }
        public virtual DbSet<Codigospostales> Codigospostales { get; set; }
        public virtual DbSet<DatosVerificacionMati> DatosVerificacionMati { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<EstadosMexico> EstadosMexico { get; set; }
        public virtual DbSet<Gadgets> Gadgets { get; set; }
        public virtual DbSet<InsigniaCotizacion> InsigniaCotizacion { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<MarcasAseguradoras> MarcasAseguradoras { get; set; }
        public virtual DbSet<MedidasSeguridad> MedidasSeguridad { get; set; }
        public virtual DbSet<MetodosPagoReg> MetodosPagoReg { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<ModelosAseguradoras> ModelosAseguradoras { get; set; }
        public virtual DbSet<ModelosMoto> ModelosMoto { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<NivelesCondominio> NivelesCondominio { get; set; }
        public virtual DbSet<OauthAccessToken> OauthAccessToken { get; set; }
        public virtual DbSet<OauthClientDetails> OauthClientDetails { get; set; }
        public virtual DbSet<OauthClientToken> OauthClientToken { get; set; }
        public virtual DbSet<OauthCode> OauthCode { get; set; }
        public virtual DbSet<OauthRefreshToken> OauthRefreshToken { get; set; }
        public virtual DbSet<Ocupaciones> Ocupaciones { get; set; }
        public virtual DbSet<Parentesco> Parentesco { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<PerfilAsegurado> PerfilAsegurado { get; set; }
        public virtual DbSet<PerfilAseguradoTieneGadgets> PerfilAseguradoTieneGadgets { get; set; }
        public virtual DbSet<PerfilAseguradoToActividades> PerfilAseguradoToActividades { get; set; }
        public virtual DbSet<PerfilAseguradoToPropiedades> PerfilAseguradoToPropiedades { get; set; }
        public virtual DbSet<PerfilAseguradoToSalud> PerfilAseguradoToSalud { get; set; }
        public virtual DbSet<PisosCasas> PisosCasas { get; set; }
        public virtual DbSet<Polizas> Polizas { get; set; }
        public virtual DbSet<PolizasAseguradorasNoAgente> PolizasAseguradorasNoAgente { get; set; }
        public virtual DbSet<PolizasGadgets> PolizasGadgets { get; set; }
        public virtual DbSet<PolizasGastosMedicos> PolizasGastosMedicos { get; set; }
        public virtual DbSet<PolizasHogar> PolizasHogar { get; set; }
        public virtual DbSet<PolizasMascotas> PolizasMascotas { get; set; }
        public virtual DbSet<PolizasMoto> PolizasMoto { get; set; }
        public virtual DbSet<PolizasRc> PolizasRc { get; set; }
        public virtual DbSet<PolizasViajes> PolizasViajes { get; set; }
        public virtual DbSet<PolizasVida> PolizasVida { get; set; }
        public virtual DbSet<Preguntas> Preguntas { get; set; }
        public virtual DbSet<PreguntasChat> PreguntasChat { get; set; }
        public virtual DbSet<PreguntasHogar> PreguntasHogar { get; set; }
        public virtual DbSet<PreguntasPerfil> PreguntasPerfil { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<ProductosBrokfy> ProductosBrokfy { get; set; }
        public virtual DbSet<Profesiones> Profesiones { get; set; }
        public virtual DbSet<Propiedades> Propiedades { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Salud> Salud { get; set; }
        public virtual DbSet<Sexo> Sexo { get; set; }
        public virtual DbSet<Siniestros> Siniestros { get; set; }
        public virtual DbSet<Sotanos> Sotanos { get; set; }
        public virtual DbSet<TipoPoliza> TipoPoliza { get; set; }
        public virtual DbSet<TipoSeguro> TipoSeguro { get; set; }
        public virtual DbSet<TipoTecho> TipoTecho { get; set; }
        public virtual DbSet<TipoViviendaBrokfy> TipoViviendaBrokfy { get; set; }
        public virtual DbSet<TiposMuro> TiposMuro { get; set; }
        public virtual DbSet<Tiposuelo> Tiposuelo { get; set; }
        public virtual DbSet<UsoVivienda> UsoVivienda { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuariosToRoles> UsuariosToRoles { get; set; }
        public virtual DbSet<Vida> Vida { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actividades>(entity =>
            {
                entity.ToTable("actividades");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<AnosMarca>(entity =>
            {
                entity.HasKey(e => e.AnoMarac)
                    .HasName("PRIMARY");

                entity.ToTable("anos_marca");

                entity.Property(e => e.AnoMarac)
                    .HasColumnName("ano_marac")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Aseguradoras>(entity =>
            {
                entity.HasKey(e => e.IdAseguradora)
                    .HasName("PRIMARY");

                entity.ToTable("aseguradoras");

                entity.Property(e => e.IdAseguradora)
                    .HasColumnName("id_aseguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CveCopsis)
                    .IsRequired()
                    .HasColumnName("cve_copsis")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasColumnName("enabled")
                    .HasColumnType("enum('Si','No')")
                    .HasDefaultValueSql("'Si'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Auto>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("auto");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ano)
                    .HasColumnName("ano")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodigoPostal)
                    .IsRequired()
                    .HasColumnName("codigo_postal")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Placas)
                    .IsRequired()
                    .HasColumnName("placas")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithOne(p => p.Auto)
                    .HasForeignKey<Auto>(d => d.NoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auto_polizas1");
            });

            modelBuilder.Entity<Bankcode>(entity =>
            {
                entity.HasKey(e => new { e.Banco, e.CodQualitas })
                    .HasName("PRIMARY");

                entity.ToTable("bankcode");

                entity.Property(e => e.Banco)
                    .HasColumnName("banco")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodQualitas)
                    .HasColumnName("codQualitas")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BeneficiariosVida>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NoPoliza })
                    .HasName("PRIMARY");

                entity.ToTable("beneficiarios_vida");

                entity.HasIndex(e => e.IdParentesco)
                    .HasName("fk_parentesco_beneficiario_idx");

                entity.HasIndex(e => e.NoPoliza)
                    .HasName("fk_beneficiarios_vida_vida_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasColumnName("apellido_materno")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasColumnName("apellido_paterno")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasColumnName("curp")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdParentesco)
                    .HasColumnName("id_parentesco")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PctAsignado)
                    .IsRequired()
                    .HasColumnName("pct_asignado")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdParentescoNavigation)
                    .WithMany(p => p.BeneficiariosVida)
                    .HasForeignKey(d => d.IdParentesco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_parentesco_beneficiario");

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithMany(p => p.BeneficiariosVida)
                    .HasForeignKey(d => d.NoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_beneficiarios_vida_vida");
            });

            modelBuilder.Entity<Bfroles>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.ToTable("bfroles");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.NameRol)
                    .IsRequired()
                    .HasColumnName("name_rol")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Bfroleusers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bfroleusers");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Bfusers>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PRIMARY");

                entity.ToTable("bfusers");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CartasNombramiento>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("cartas_nombramiento");

                entity.HasIndex(e => e.Aseguradora)
                    .HasName("FK_Aseguradoras_idx");

                entity.HasIndex(e => e.Tipo)
                    .HasName("fk_tipo_poliza_carta_nombramiento_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Aseguradora)
                    .HasColumnName("aseguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Firmada).HasColumnName("firmada");

                entity.Property(e => e.Revisado).HasColumnName("revisado");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UrlCartaNombramiento)
                    .HasColumnName("url_carta_nombramiento")
                    .HasColumnType("varchar(245)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlPoliza)
                    .HasColumnName("url_poliza")
                    .HasColumnType("varchar(245)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.AseguradoraNavigation)
                    .WithMany(p => p.CartasNombramiento)
                    .HasForeignKey(d => d.Aseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Aseguradoras");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.CartasNombramiento)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tipo_poliza_carta_nombramiento");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.CartasNombramiento)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios");
            });

            modelBuilder.Entity<CatalogoHomologado>(entity =>
            {
                entity.HasKey(e => e.CodAmis)
                    .HasName("PRIMARY");

                entity.ToTable("catalogo_homologado");

                entity.Property(e => e.CodAmis)
                    .HasColumnName("codAmis")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodAna)
                    .IsRequired()
                    .HasColumnName("codAna")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ChatAutomoviles>(entity =>
            {
                entity.ToTable("chat_automoviles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoRespuesta)
                    .HasColumnName("tipo_respuesta")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChatHogar>(entity =>
            {
                entity.ToTable("chat_hogar");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoRespuesta)
                    .HasColumnName("tipo_respuesta")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChatVida>(entity =>
            {
                entity.ToTable("chat_vida");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoRespuesta)
                    .IsRequired()
                    .HasColumnName("tipo_respuesta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Coberturas>(entity =>
            {
                entity.HasKey(e => e.IdCoberturas)
                    .HasName("PRIMARY");

                entity.ToTable("coberturas");

                entity.HasIndex(e => e.ProductosId)
                    .HasName("fk_coberturas_productos1_idx");

                entity.Property(e => e.IdCoberturas)
                    .HasColumnName("id_coberturas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductosId)
                    .HasColumnName("productos_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Productos)
                    .WithMany(p => p.Coberturas)
                    .HasForeignKey(d => d.ProductosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coberturas_productos1");
            });

            modelBuilder.Entity<Codigospostales>(entity =>
            {
                entity.ToTable("codigospostales");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codpostal)
                    .IsRequired()
                    .HasColumnName("codpostal")
                    .HasColumnType("varchar(7)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnName("colonia")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("municipio")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<DatosVerificacionMati>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PRIMARY");

                entity.ToTable("datos_verificacion_mati");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Curp)
                    .HasColumnName("curp")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Emision)
                    .HasColumnName("emision")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaExpiracion)
                    .HasColumnName("fechaExpiracion")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FotoDelantera)
                    .IsRequired()
                    .HasColumnName("foto_delantera")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FotoTrasera)
                    .IsRequired()
                    .HasColumnName("foto_trasera")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Genero)
                    .HasColumnName("genero")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NacionalidadIdentificacion)
                    .HasColumnName("nacionalidad_identificacion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("numDocumento")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OcrNumber)
                    .HasColumnName("ocrNumber")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Selfie)
                    .HasColumnName("selfie")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoDocumento)
                    .HasColumnName("tipo_documento")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.ToTable("estado_civil");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EstadosMexico>(entity =>
            {
                entity.ToTable("estados_mexico");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Aseguradora)
                    .IsRequired()
                    .HasColumnName("aseguradora")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdAseguradora)
                    .IsRequired()
                    .HasColumnName("id_aseguradora")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Gadgets>(entity =>
            {
                entity.ToTable("gadgets");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<InsigniaCotizacion>(entity =>
            {
                entity.ToTable("insignia_cotizacion");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Edad)
                    .IsRequired()
                    .HasColumnName("edad")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Frecuencia)
                    .IsRequired()
                    .HasColumnName("frecuencia")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Fumador).HasColumnName("fumador");

                entity.Property(e => e.GeneroTitular)
                    .IsRequired()
                    .HasColumnName("genero_titular")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PrimaAnual)
                    .IsRequired()
                    .HasColumnName("prima_anual")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PrimaFraccionada)
                    .IsRequired()
                    .HasColumnName("prima_fraccionada")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SumaAsegurada)
                    .IsRequired()
                    .HasColumnName("suma_asegurada")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SumaSeleccionada)
                    .IsRequired()
                    .HasColumnName("suma_seleccionada")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.ToTable("marcas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MarcasAseguradoras>(entity =>
            {
                entity.HasKey(e => new { e.Nombre, e.CodMarca })
                    .HasName("PRIMARY");

                entity.ToTable("marcas_aseguradoras");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodMarca)
                    .HasColumnName("codMarca")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Aseguradora)
                    .IsRequired()
                    .HasColumnName("aseguradora")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MedidasSeguridad>(entity =>
            {
                entity.ToTable("medidas_seguridad");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdChubb)
                    .HasColumnName("id_chubb")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<MetodosPagoReg>(entity =>
            {
                entity.ToTable("metodos_pago_reg");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_metodos_pago_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Defecto)
                    .HasColumnName("defecto")
                    .HasColumnType("enum('true','false')")
                    .HasDefaultValueSql("'false'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.MetodosPagoReg)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("fk_usuarios_metodos_pago");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.ToTable("modelo");

                entity.HasIndex(e => e.IdMarca)
                    .HasName("fk_marcas_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMarca)
                    .HasColumnName("id_marca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.InverseIdMarcaNavigation)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_marcas");
            });

            modelBuilder.Entity<ModelosAseguradoras>(entity =>
            {
                entity.ToTable("modelos_aseguradoras");

                entity.HasIndex(e => e.CodBrokfy)
                    .HasName("fk_modelos_aseguradoras_marcas_brokfy_idx");

                entity.HasIndex(e => e.Marcas)
                    .HasName("fk_modelos_aseguradoras_marcas_aseguradoras1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnioComercializacion)
                    .IsRequired()
                    .HasColumnName("anio_comercializacion")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Aseguradora)
                    .IsRequired()
                    .HasColumnName("aseguradora")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodBrokfy)
                    .HasColumnName("cod_brokfy")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CodModelo)
                    .IsRequired()
                    .HasColumnName("cod_modelo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Marcas)
                    .IsRequired()
                    .HasColumnName("marcas")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NomModelo)
                    .IsRequired()
                    .HasColumnName("nom_modelo")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.CodBrokfyNavigation)
                    .WithMany(p => p.ModelosAseguradoras)
                    .HasForeignKey(d => d.CodBrokfy)
                    .HasConstraintName("fk_modelos_aseguradoras_marcas_brokfy");
            });

            modelBuilder.Entity<ModelosMoto>(entity =>
            {
                entity.ToTable("modelos_moto");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnioComercializacion)
                    .IsRequired()
                    .HasColumnName("anio_comercializacion")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodModelo)
                    .IsRequired()
                    .HasColumnName("cod_modelo")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NomModelo)
                    .IsRequired()
                    .HasColumnName("nom_modelo")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.HasKey(e => new { e.Municipio, e.Estado })
                    .HasName("PRIMARY");

                entity.ToTable("municipios");

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodMunicipio)
                    .IsRequired()
                    .HasColumnName("cod_municipio")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<NivelesCondominio>(entity =>
            {
                entity.ToTable("nivelesCondominio");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("idAfirme")
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("'1x0x0x0x50'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Nivel)
                    .HasColumnName("nivel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValidadorAfirme)
                    .HasColumnName("validadorAfirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<OauthAccessToken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("oauth_access_token");

                entity.Property(e => e.Authentication)
                    .HasColumnName("authentication")
                    .HasColumnType("blob");

                entity.Property(e => e.AuthenticationId)
                    .HasColumnName("authentication_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefreshToken)
                    .HasColumnName("refresh_token")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("blob");

                entity.Property(e => e.TokenId)
                    .HasColumnName("token_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<OauthClientDetails>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("PRIMARY");

                entity.ToTable("oauth_client_details");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AccessTokenValidity)
                    .HasColumnName("access_token_validity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdditionalInformation)
                    .HasColumnName("additional_information")
                    .HasColumnType("varchar(4096)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Authorities)
                    .HasColumnName("authorities")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizedGrantTypes)
                    .HasColumnName("authorized_grant_types")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Autoapprove)
                    .HasColumnName("autoapprove")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ClientSecret)
                    .HasColumnName("client_secret")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RefreshTokenValidity)
                    .HasColumnName("refresh_token_validity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceIds)
                    .HasColumnName("resource_ids")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Scope)
                    .HasColumnName("scope")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebServerRedirectUri)
                    .HasColumnName("web_server_redirect_uri")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<OauthClientToken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("oauth_client_token");

                entity.Property(e => e.AuthenticationId)
                    .HasColumnName("authentication_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("blob");

                entity.Property(e => e.TokenId)
                    .HasColumnName("token_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<OauthCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("oauth_code");

                entity.Property(e => e.Authentication)
                    .HasColumnName("authentication")
                    .HasColumnType("blob");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<OauthRefreshToken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("oauth_refresh_token");

                entity.Property(e => e.Authentication)
                    .HasColumnName("authentication")
                    .HasColumnType("blob");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("blob");

                entity.Property(e => e.TokenId)
                    .HasColumnName("token_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ocupaciones>(entity =>
            {
                entity.ToTable("ocupaciones");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Parentesco>(entity =>
            {
                entity.ToTable("parentesco");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PRIMARY");

                entity.ToTable("perfil");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasColumnName("apellido_materno")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasColumnName("apellido_paterno")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasColumnName("sexo")
                    .HasColumnType("enum('Femenino','Masculino')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithOne(p => p.Perfil)
                    .HasForeignKey<Perfil>(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_perfil");
            });

            modelBuilder.Entity<PerfilAsegurado>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PRIMARY");

                entity.ToTable("perfil_asegurado");

                entity.HasIndex(e => e.IdProfesion)
                    .HasName("fk_perfil_asegurado_profesiones_idx");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodigoPostal)
                    .IsRequired()
                    .HasColumnName("codigo_postal")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Edad)
                    .IsRequired()
                    .HasColumnName("edad")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.EstadoCivil)
                    .IsRequired()
                    .HasColumnName("estado_civil")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Hijos)
                    .IsRequired()
                    .HasColumnName("hijos")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Hipoteca).HasColumnName("hipoteca");

                entity.Property(e => e.IdProfesion)
                    .HasColumnName("id_profesion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mascotas).HasColumnName("mascotas");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("municipio")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RegimenVivienda)
                    .IsRequired()
                    .HasColumnName("regimen_vivienda")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SituacionLaboral)
                    .IsRequired()
                    .HasColumnName("situacion_laboral")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Viaja).HasColumnName("viaja");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithOne(p => p.PerfilAsegurado)
                    .HasForeignKey<PerfilAsegurado>(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_usuario");

                entity.HasOne(d => d.IdProfesionNavigation)
                    .WithMany(p => p.PerfilAsegurado)
                    .HasForeignKey(d => d.IdProfesion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_profesiones");
            });

            modelBuilder.Entity<PerfilAseguradoTieneGadgets>(entity =>
            {
                entity.HasKey(e => new { e.IdPerfil, e.IdGadgets })
                    .HasName("PRIMARY");

                entity.ToTable("perfil_asegurado_tiene_gadgets");

                entity.HasIndex(e => e.IdGadgets)
                    .HasName("fk_perfil_asegurado_has_gadgets_gadgets1_idx");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("fk_perfil_asegurado_has_gadgets_perfil_asegurado1_idx");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdGadgets)
                    .HasColumnName("id_gadgets")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seguro).HasColumnName("seguro");

                entity.HasOne(d => d.IdGadgetsNavigation)
                    .WithMany(p => p.PerfilAseguradoTieneGadgets)
                    .HasForeignKey(d => d.IdGadgets)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_has_gadgets_gadgets1");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilAseguradoTieneGadgets)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_has_gadgets_perfil_asegurado1");
            });

            modelBuilder.Entity<PerfilAseguradoToActividades>(entity =>
            {
                entity.HasKey(e => new { e.IdPerfil, e.IdActividad })
                    .HasName("PRIMARY");

                entity.ToTable("perfil_asegurado_to_actividades");

                entity.HasIndex(e => e.IdActividad)
                    .HasName("fk_perfi_asegurado_actividades_actividad_idx");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdActividad)
                    .HasColumnName("id_actividad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seguro).HasColumnName("seguro");

                entity.HasOne(d => d.IdActividadNavigation)
                    .WithMany(p => p.PerfilAseguradoToActividades)
                    .HasForeignKey(d => d.IdActividad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfi_asegurado_actividades_actividad");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilAseguradoToActividades)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfi_asegurado_actividades_perfil");
            });

            modelBuilder.Entity<PerfilAseguradoToPropiedades>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("perfil_asegurado_to_propiedades");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("fk_perfil_asegurado_has_propiedades_perfil_asegurado1_idx");

                entity.HasIndex(e => e.IdPropiedades)
                    .HasName("fk_perfil_asegurado_has_propiedades_propiedades1_idx");

                entity.Property(e => e.IdPerfil)
                    .IsRequired()
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdPropiedades)
                    .HasColumnName("id_propiedades")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_has_perfil");

                entity.HasOne(d => d.IdPropiedadesNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPropiedades)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_has_propiedades_propiedades1");
            });

            modelBuilder.Entity<PerfilAseguradoToSalud>(entity =>
            {
                entity.HasKey(e => new { e.IdPerfil, e.IdSalud })
                    .HasName("PRIMARY");

                entity.ToTable("perfil_asegurado_to_salud");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("fk_perfil_asegurado_has_salud_perfil_asegurado1_idx");

                entity.HasIndex(e => e.IdSalud)
                    .HasName("fk_perfil_asegurado_has_salud_salud1_idx");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdSalud)
                    .HasColumnName("id_salud")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seguro).HasColumnName("seguro");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilAseguradoToSalud)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_has_perfil_perfil");

                entity.HasOne(d => d.IdSaludNavigation)
                    .WithMany(p => p.PerfilAseguradoToSalud)
                    .HasForeignKey(d => d.IdSalud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_has_salud_salud1");
            });

            modelBuilder.Entity<PisosCasas>(entity =>
            {
                entity.ToTable("pisosCasas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .IsRequired()
                    .HasColumnName("etiqueta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdChubb)
                    .HasColumnName("idChubb")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Polizas>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas");

                entity.HasIndex(e => e.IdAseguradoras)
                    .HasName("fk_polizas_aseguradoras1_idx");

                entity.HasIndex(e => e.ProductoId)
                    .HasName("fk_polizas_productos1_idx");

                entity.HasIndex(e => e.TipoPoliza)
                    .HasName("fk_tipo_polizas_polizas_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_polizas_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.CostoPrimerRecibo)
                    .HasColumnName("costo_primer_recibo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CostoRecibosSubsecuentes)
                    .HasColumnName("costo_recibos_subsecuentes")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fecha_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasColumnName("forma_pago")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Habilitada)
                    .IsRequired()
                    .HasColumnName("habilitada")
                    .HasColumnType("enum('Si','No')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdAseguradoras)
                    .HasColumnName("id_aseguradoras")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoAsegurado)
                    .HasColumnName("no_asegurado")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PolizaPdf)
                    .HasColumnName("poliza_pdf")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PolizaPropia)
                    .HasColumnName("poliza_propia")
                    .HasColumnType("enum('Si','No')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ProximoPago)
                    .HasColumnName("proximo_pago")
                    .HasColumnType("date");

                entity.Property(e => e.RcUsaCanada)
                    .HasColumnName("rc_usa_canada")
                    .HasColumnType("varchar(105)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReciboPdf)
                    .HasColumnName("recibo_pdf")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoPoliza)
                    .HasColumnName("tipo_poliza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdAseguradorasNavigation)
                    .WithMany(p => p.Polizas)
                    .HasForeignKey(d => d.IdAseguradoras)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_polizas_aseguradoras1");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Polizas)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_polizas_productos1");

                entity.HasOne(d => d.TipoPolizaNavigation)
                    .WithMany(p => p.Polizas)
                    .HasForeignKey(d => d.TipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tipo_polizas_polizas");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Polizas)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_polizas");
            });

            modelBuilder.Entity<PolizasAseguradorasNoAgente>(entity =>
            {
                entity.ToTable("polizas_aseguradoras_no_agente");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_polizas_no_agente_usuarios_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPoliza)
                    .HasColumnName("id_poliza")
                    .HasColumnType("bigint(11)");

                entity.Property(e => e.UrlPoliza)
                    .IsRequired()
                    .HasColumnName("url_poliza")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasAseguradorasNoAgente)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_polizas_no_agente_usuarios");
            });

            modelBuilder.Entity<PolizasGadgets>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas_gadgets");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_gadgets_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasGadgets)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_gadgets");
            });

            modelBuilder.Entity<PolizasGastosMedicos>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas_gastos_medicos");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_gastos_medicos_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoPoliza)
                    .IsRequired()
                    .HasColumnName("tipo_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasGastosMedicos)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_gastos_medicos");
            });

            modelBuilder.Entity<PolizasHogar>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas_hogar");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_hogar_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasHogar)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_hogar");
            });

            modelBuilder.Entity<PolizasMascotas>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas_mascotas");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_mascotas_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasMascotas)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_mascotas");
            });

            modelBuilder.Entity<PolizasMoto>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas_moto");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_moto");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasMoto)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_moto");
            });

            modelBuilder.Entity<PolizasRc>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas_rc");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_rc_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasRc)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_rc");
            });

            modelBuilder.Entity<PolizasViajes>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas_viajes");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PolizasVida>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas_vida");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuario_vida_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasVida)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_vida");
            });

            modelBuilder.Entity<Preguntas>(entity =>
            {
                entity.ToTable("preguntas");

                entity.HasIndex(e => e.TipoSeguroId)
                    .HasName("fk_preguntas_tipo_seguro1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasColumnType("varchar(75)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoSeguroId)
                    .HasColumnName("tipo_seguro_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.TipoSeguro)
                    .WithMany(p => p.Preguntas)
                    .HasForeignKey(d => d.TipoSeguroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_preguntas_tipo_seguro1");
            });

            modelBuilder.Entity<PreguntasChat>(entity =>
            {
                entity.HasKey(e => new { e.IdPregunta, e.Pregunta })
                    .HasName("PRIMARY");

                entity.ToTable("preguntas_chat");

                entity.HasIndex(e => e.Id)
                    .HasName("chat_automoviles_idx");

                entity.HasIndex(e => e.IdHogar)
                    .HasName("chat_hogar_idx");

                entity.HasIndex(e => e.IdVida)
                    .HasName("fk_chat_vida_idx");

                entity.Property(e => e.IdPregunta)
                    .HasColumnName("id_pregunta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pregunta)
                    .HasColumnName("pregunta")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdHogar)
                    .HasColumnName("id_hogar")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVida)
                    .HasColumnName("id_vida")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.PreguntasChat)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("chat_automoviles");

                entity.HasOne(d => d.IdHogarNavigation)
                    .WithMany(p => p.PreguntasChat)
                    .HasForeignKey(d => d.IdHogar)
                    .HasConstraintName("chat_hogar");

                entity.HasOne(d => d.IdVidaNavigation)
                    .WithMany(p => p.PreguntasChat)
                    .HasForeignKey(d => d.IdVida)
                    .HasConstraintName("fk_chat_vida");
            });

            modelBuilder.Entity<PreguntasHogar>(entity =>
            {
                entity.ToTable("preguntasHogar");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'200'");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasColumnType("varchar(65)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TipoRespuesta)
                    .HasColumnName("tipoRespuesta")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PreguntasPerfil>(entity =>
            {
                entity.ToTable("preguntas_perfil");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TipoRespuesta)
                    .HasColumnName("tipo_respuesta")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.ToTable("productos");

                entity.HasIndex(e => e.Aseguradora)
                    .HasName("fk_productos_aseguradoras1_idx");

                entity.HasIndex(e => e.IdProductos)
                    .HasName("fk_idProductos_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Aseguradora)
                    .HasColumnName("aseguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProductos)
                    .HasColumnName("id_productos")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasColumnName("producto")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("xml")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.XmlEmision)
                    .HasColumnName("xml_emision")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.AseguradoraNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.Aseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_productos_aseguradoras1");

                entity.HasOne(d => d.IdProductosNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdProductos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_productos");
            });

            modelBuilder.Entity<ProductosBrokfy>(entity =>
            {
                entity.ToTable("productos_brokfy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasColumnName("producto")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Profesiones>(entity =>
            {
                entity.ToTable("profesiones");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Propiedades>(entity =>
            {
                entity.ToTable("propiedades");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Salud>(entity =>
            {
                entity.ToTable("salud");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.ToTable("sexo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Siniestros>(entity =>
            {
                entity.HasKey(e => e.IdSiniestros)
                    .HasName("PRIMARY");

                entity.ToTable("siniestros");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_siniestros_usuarios_idx");

                entity.Property(e => e.IdSiniestros)
                    .HasColumnName("idSiniestros")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoSiniestro)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Siniestros)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_siniestros_usuarios");
            });

            modelBuilder.Entity<Sotanos>(entity =>
            {
                entity.ToTable("sotanos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .IsRequired()
                    .HasColumnName("etiqueta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdChubb)
                    .HasColumnName("idChubb")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TipoPoliza>(entity =>
            {
                entity.ToTable("tipo_poliza");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TipoSeguro>(entity =>
            {
                entity.ToTable("tipo_seguro");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seguro)
                    .IsRequired()
                    .HasColumnName("seguro")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TipoTecho>(entity =>
            {
                entity.ToTable("tipo_techo");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("id_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdChubb)
                    .HasColumnName("id_chubb")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ValidadorAfirme)
                    .HasColumnName("validador_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ValorAfirme)
                    .HasColumnName("valor_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TipoViviendaBrokfy>(entity =>
            {
                entity.ToTable("tipo_vivienda_brokfy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("id_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdChubb)
                    .HasColumnName("id_chubb")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ValidadorAfirme)
                    .HasColumnName("validador_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ValorAfirme)
                    .HasColumnName("valor_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TiposMuro>(entity =>
            {
                entity.ToTable("tipos_muro");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("id_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdChubb)
                    .HasColumnName("id_chubb")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ValidadorAfirme)
                    .HasColumnName("validador_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ValorAfirme)
                    .HasColumnName("valor_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Tiposuelo>(entity =>
            {
                entity.HasKey(e => e.IdTipoSuelo)
                    .HasName("PRIMARY");

                entity.ToTable("tiposuelo");

                entity.Property(e => e.IdTipoSuelo)
                    .HasColumnName("idTipoSuelo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<UsoVivienda>(entity =>
            {
                entity.ToTable("uso_vivienda");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("id_afirme")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Validador)
                    .HasColumnName("validador")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.IdConekta)
                    .HasColumnName("id_conekta")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Intentos)
                    .HasColumnName("intentos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NameAws)
                    .HasColumnName("name_aws")
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TokenF)
                    .HasColumnName("token_f")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<UsuariosToRoles>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.RoleId })
                    .HasName("PRIMARY");

                entity.ToTable("usuarios_to_roles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("FK_ROLE_1_idx");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("FK_USUARIOS_1_idx");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsuariosToRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ROLE_1");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuariosToRoles)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIOS_1");
            });

            modelBuilder.Entity<Vida>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("vida");

                entity.HasIndex(e => e.IdEstadoCivil)
                    .HasName("fk_estado_civil_vida_idx");

                entity.HasIndex(e => e.IdOcupacion)
                    .HasName("fk_ocupacion_vida_idx");

                entity.HasIndex(e => e.IdSexo)
                    .HasName("fk_sexo_vida_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estatura)
                    .IsRequired()
                    .HasColumnName("estatura")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Fumador).HasColumnName("fumador");

                entity.Property(e => e.IdEstadoCivil)
                    .HasColumnName("id_estado_civil")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOcupacion)
                    .HasColumnName("id_ocupacion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSexo)
                    .HasColumnName("id_sexo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ingresos)
                    .HasColumnName("ingresos")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Peso)
                    .IsRequired()
                    .HasColumnName("peso")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.Vida)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estado_civil_vida");

                entity.HasOne(d => d.IdOcupacionNavigation)
                    .WithMany(p => p.Vida)
                    .HasForeignKey(d => d.IdOcupacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ocupacon_vida");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany(p => p.Vida)
                    .HasForeignKey(d => d.IdSexo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sexo_vida");

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithOne(p => p.Vida)
                    .HasForeignKey<Vida>(d => d.NoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_polizas_vida");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
