using System;
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

        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<AnosMarca> AnosMarca { get; set; }
        public virtual DbSet<Aseguradoras> Aseguradoras { get; set; }
        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Bankcode> Bankcode { get; set; }
        public virtual DbSet<Bfroles> Bfroles { get; set; }
        public virtual DbSet<Bfusers> Bfusers { get; set; }
        public virtual DbSet<CartasNombramiento> CartasNombramiento { get; set; }
        public virtual DbSet<CatalogoHomologado> CatalogoHomologado { get; set; }
        public virtual DbSet<ChatAutomoviles> ChatAutomoviles { get; set; }
        public virtual DbSet<ChatHogar> ChatHogar { get; set; }
        public virtual DbSet<Coberturas> Coberturas { get; set; }
        public virtual DbSet<Codigospostales> Codigospostales { get; set; }
        public virtual DbSet<DatosVerificacionMati> DatosVerificacionMati { get; set; }
        public virtual DbSet<EstadosMexico> EstadosMexico { get; set; }
        public virtual DbSet<Gadgets> Gadgets { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<MarcasAseguradoras> MarcasAseguradoras { get; set; }
        public virtual DbSet<MedidasSeguridad> MedidasSeguridad { get; set; }
        public virtual DbSet<MetodosPagoReg> MetodosPagoReg { get; set; }
        public virtual DbSet<Modelo> Modelo { get; set; }
        public virtual DbSet<ModelosAseguradoras> ModelosAseguradoras { get; set; }
        public virtual DbSet<ModelosMoto> ModelosMoto { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<NivelesCondominio> NivelesCondominio { get; set; }
        public virtual DbSet<OauthClientDetails> OauthClientDetails { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<PerfilAsegurado> PerfilAsegurado { get; set; }
        public virtual DbSet<PerfilAseguradoTieneGadgets> PerfilAseguradoTieneGadgets { get; set; }
        public virtual DbSet<PerfilAseguradoToActividades> PerfilAseguradoToActividades { get; set; }
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

        // Unable to generate entity type for table 'brokfy_dev.bfroleusers'. Please see the warning messages.
        // Unable to generate entity type for table 'brokfy_dev.oauth_access_token'. Please see the warning messages.
        // Unable to generate entity type for table 'brokfy_dev.oauth_client_token'. Please see the warning messages.
        // Unable to generate entity type for table 'brokfy_dev.oauth_code'. Please see the warning messages.
        // Unable to generate entity type for table 'brokfy_dev.oauth_refresh_token'. Please see the warning messages.
        // Unable to generate entity type for table 'brokfy_dev.perfil_asegurado_to_propiedades'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL(@"server=database-1.cyu1bxjzzhpm.us-east-2.rds.amazonaws.com;port=3306;user=dev;password=DevBrokfy18;database=brokfy_dev");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Actividades>(entity =>
            {
                entity.ToTable("actividades", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnosMarca>(entity =>
            {
                entity.HasKey(e => e.AnoMarac);

                entity.ToTable("anos_marca", "brokfy_dev");

                entity.Property(e => e.AnoMarac)
                    .HasColumnName("ano_marac")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Aseguradoras>(entity =>
            {
                entity.HasKey(e => e.IdAseguradora);

                entity.ToTable("aseguradoras", "brokfy_dev");

                entity.Property(e => e.IdAseguradora)
                    .HasColumnName("id_aseguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CveCopsis)
                    .IsRequired()
                    .HasColumnName("cve_copsis")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasColumnName("enabled")
                    .HasColumnType("enum('Si','No')")
                    .HasDefaultValueSql("Si");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Auto>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("auto", "brokfy_dev");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ano)
                    .HasColumnName("ano")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Placas)
                    .IsRequired()
                    .HasColumnName("placas")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithOne(p => p.Auto)
                    .HasForeignKey<Auto>(d => d.NoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_auto_polizas1");
            });

            modelBuilder.Entity<Bankcode>(entity =>
            {
                entity.HasKey(e => new { e.Banco, e.CodQualitas });

                entity.ToTable("bankcode", "brokfy_dev");

                entity.Property(e => e.Banco)
                    .HasColumnName("banco")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CodQualitas)
                    .HasColumnName("codQualitas")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bfroles>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.ToTable("bfroles", "brokfy_dev");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.NameRol)
                    .IsRequired()
                    .HasColumnName("name_rol")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bfusers>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("bfusers", "brokfy_dev");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CartasNombramiento>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("cartas_nombramiento", "brokfy_dev");

                entity.HasIndex(e => e.Tipo)
                    .HasName("fk_tipo_poliza_carta_nombramiento_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Aseguradora)
                    .IsRequired()
                    .HasColumnName("aseguradora")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Revisado)
                    .HasColumnName("revisado")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UrlPoliza)
                    .HasColumnName("url_poliza")
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

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
                entity.HasKey(e => e.CodAmis);

                entity.ToTable("catalogo_homologado", "brokfy_dev");

                entity.Property(e => e.CodAmis)
                    .HasColumnName("codAmis")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodAna)
                    .IsRequired()
                    .HasColumnName("codAna")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChatAutomoviles>(entity =>
            {
                entity.ToTable("chat_automoviles", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TipoRespuesta)
                    .HasColumnName("tipo_respuesta")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChatHogar>(entity =>
            {
                entity.ToTable("chat_hogar", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TipoRespuesta)
                    .HasColumnName("tipo_respuesta")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Coberturas>(entity =>
            {
                entity.HasKey(e => e.IdCoberturas);

                entity.ToTable("coberturas", "brokfy_dev");

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
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Productos)
                    .WithMany(p => p.Coberturas)
                    .HasForeignKey(d => d.ProductosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coberturas_productos1");
            });

            modelBuilder.Entity<Codigospostales>(entity =>
            {
                entity.ToTable("codigospostales", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codpostal)
                    .IsRequired()
                    .HasColumnName("codpostal")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnName("colonia")
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("municipio")
                    .HasMaxLength(145)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatosVerificacionMati>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("datos_verificacion_mati", "brokfy_dev");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Curp)
                    .HasColumnName("curp")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).HasColumnName("direccion");

                entity.Property(e => e.Emision)
                    .HasColumnName("emision")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaExpiracion)
                    .HasColumnName("fechaExpiracion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FotoDelantera)
                    .IsRequired()
                    .HasColumnName("foto_delantera")
                    .HasColumnType("longtext");

                entity.Property(e => e.FotoTrasera)
                    .IsRequired()
                    .HasColumnName("foto_trasera")
                    .HasColumnType("longtext");

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .HasColumnName("genero")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NacionalidadIdentificacion)
                    .HasColumnName("nacionalidad_identificacion")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("numDocumento")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OcrNumber)
                    .HasColumnName("ocrNumber")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Selfie)
                    .HasColumnName("selfie")
                    .HasColumnType("longtext");

                entity.Property(e => e.TipoDocumento)
                    .HasColumnName("tipo_documento")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadosMexico>(entity =>
            {
                entity.ToTable("estados_mexico", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Aseguradora)
                    .IsRequired()
                    .HasColumnName("aseguradora")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdAseguradora)
                    .IsRequired()
                    .HasColumnName("id_aseguradora")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gadgets>(entity =>
            {
                entity.ToTable("gadgets", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.ToTable("marcas", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarcasAseguradoras>(entity =>
            {
                entity.HasKey(e => new { e.CodMarca, e.Nombre });

                entity.ToTable("marcas_aseguradoras", "brokfy_dev");

                entity.Property(e => e.CodMarca)
                    .HasColumnName("codMarca")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Aseguradora)
                    .IsRequired()
                    .HasColumnName("aseguradora")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MedidasSeguridad>(entity =>
            {
                entity.ToTable("medidas_seguridad", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdChubb)
                    .HasColumnName("id_chubb")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MetodosPagoReg>(entity =>
            {
                entity.ToTable("metodos_pago_reg", "brokfy_dev");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_metodos_pago_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Defecto)
                    .HasColumnName("defecto")
                    .HasColumnType("enum('true','false')")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.MetodosPagoReg)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("fk_usuarios_metodos_pago");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.ToTable("modelo", "brokfy_dev");

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
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.InverseIdMarcaNavigation)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_marcas");
            });

            modelBuilder.Entity<ModelosAseguradoras>(entity =>
            {
                entity.ToTable("modelos_aseguradoras", "brokfy_dev");

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
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Aseguradora)
                    .IsRequired()
                    .HasColumnName("aseguradora")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CodBrokfy)
                    .HasColumnName("cod_brokfy")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CodModelo)
                    .IsRequired()
                    .HasColumnName("cod_modelo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Marcas)
                    .IsRequired()
                    .HasColumnName("marcas")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NomModelo)
                    .IsRequired()
                    .HasColumnName("nom_modelo")
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodBrokfyNavigation)
                    .WithMany(p => p.ModelosAseguradoras)
                    .HasForeignKey(d => d.CodBrokfy)
                    .HasConstraintName("fk_modelos_aseguradoras_marcas_brokfy");
            });

            modelBuilder.Entity<ModelosMoto>(entity =>
            {
                entity.ToTable("modelos_moto", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnioComercializacion)
                    .IsRequired()
                    .HasColumnName("anio_comercializacion")
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.CodModelo)
                    .IsRequired()
                    .HasColumnName("cod_modelo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NomModelo)
                    .IsRequired()
                    .HasColumnName("nom_modelo")
                    .HasMaxLength(145)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Municipios>(entity =>
            {
                entity.HasKey(e => new { e.Municipio, e.Estado });

                entity.ToTable("municipios", "brokfy_dev");

                entity.Property(e => e.Municipio)
                    .HasColumnName("municipio")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CodMunicipio)
                    .IsRequired()
                    .HasColumnName("cod_municipio")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NivelesCondominio>(entity =>
            {
                entity.ToTable("nivelesCondominio", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("idAfirme")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("1x0x0x0x50");

                entity.Property(e => e.Nivel)
                    .HasColumnName("nivel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValidadorAfirme)
                    .HasColumnName("validadorAfirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OauthClientDetails>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.ToTable("oauth_client_details", "brokfy_dev");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessTokenValidity)
                    .HasColumnName("access_token_validity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdditionalInformation)
                    .HasColumnName("additional_information")
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.Property(e => e.Authorities)
                    .HasColumnName("authorities")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizedGrantTypes)
                    .HasColumnName("authorized_grant_types")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Autoapprove)
                    .HasColumnName("autoapprove")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ClientSecret)
                    .HasColumnName("client_secret")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RefreshTokenValidity)
                    .HasColumnName("refresh_token_validity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceIds)
                    .HasColumnName("resource_ids")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Scope)
                    .HasColumnName("scope")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WebServerRedirectUri)
                    .HasColumnName("web_server_redirect_uri")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("perfil", "brokfy_dev");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasColumnName("apellido_materno")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasColumnName("apellido_paterno")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasColumnName("sexo")
                    .HasColumnType("enum('Femenino','Masculino')");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithOne(p => p.Perfil)
                    .HasForeignKey<Perfil>(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_perfil");
            });

            modelBuilder.Entity<PerfilAsegurado>(entity =>
            {
                entity.HasKey(e => e.IdPerfil);

                entity.ToTable("perfil_asegurado", "brokfy_dev");

                entity.HasIndex(e => e.IdProfesion)
                    .HasName("fk_perfil_asegurado_profesiones_idx");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoPostal)
                    .IsRequired()
                    .HasColumnName("codigo_postal")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Edad)
                    .IsRequired()
                    .HasColumnName("edad")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCivil)
                    .IsRequired()
                    .HasColumnName("estado_civil")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Hijos)
                    .IsRequired()
                    .HasColumnName("hijos")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Hipoteca)
                    .HasColumnName("hipoteca")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdProfesion)
                    .HasColumnName("id_profesion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mascotas)
                    .HasColumnName("mascotas")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("municipio")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RegimenVivienda)
                    .IsRequired()
                    .HasColumnName("regimen_vivienda")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SituacionLaboral)
                    .IsRequired()
                    .HasColumnName("situacion_laboral")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Viaja)
                    .HasColumnName("viaja")
                    .HasColumnType("tinyint(1)");

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
                entity.HasKey(e => new { e.IdPerfil, e.IdGadgets });

                entity.ToTable("perfil_asegurado_tiene_gadgets", "brokfy_dev");

                entity.HasIndex(e => e.IdGadgets)
                    .HasName("fk_perfil_asegurado_has_gadgets_gadgets1_idx");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("fk_perfil_asegurado_has_gadgets_perfil_asegurado1_idx");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdGadgets)
                    .HasColumnName("id_gadgets")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seguro)
                    .HasColumnName("seguro")
                    .HasColumnType("tinyint(1)");

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
                entity.HasKey(e => new { e.IdPerfil, e.IdActividad });

                entity.ToTable("perfil_asegurado_to_actividades", "brokfy_dev");

                entity.HasIndex(e => e.IdActividad)
                    .HasName("fk_perfi_asegurado_actividades_actividad_idx");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdActividad)
                    .HasColumnName("id_actividad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seguro)
                    .HasColumnName("seguro")
                    .HasColumnType("tinyint(1)");

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

            modelBuilder.Entity<PerfilAseguradoToSalud>(entity =>
            {
                entity.HasKey(e => new { e.IdPerfil, e.IdSalud });

                entity.ToTable("perfil_asegurado_to_salud", "brokfy_dev");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("fk_perfil_asegurado_has_salud_perfil_asegurado1_idx");

                entity.HasIndex(e => e.IdSalud)
                    .HasName("fk_perfil_asegurado_has_salud_salud1_idx");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdSalud)
                    .HasColumnName("id_salud")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seguro)
                    .HasColumnName("seguro")
                    .HasColumnType("tinyint(1)");

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
                entity.ToTable("pisosCasas", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .IsRequired()
                    .HasColumnName("etiqueta")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdChubb)
                    .HasColumnName("idChubb")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Polizas>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("polizas", "brokfy_dev");

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
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.CostoPrimerRecibo)
                    .HasColumnName("costo_primer_recibo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CostoRecibosSubsecuentes)
                    .HasColumnName("costo_recibos_subsecuentes")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fecha_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasColumnName("forma_pago")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Habilitada)
                    .IsRequired()
                    .HasColumnName("habilitada")
                    .HasColumnType("enum('Si','No')");

                entity.Property(e => e.IdAseguradoras)
                    .HasColumnName("id_aseguradoras")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoAsegurado)
                    .HasColumnName("no_asegurado")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PolizaPdf).HasColumnName("poliza_pdf");

                entity.Property(e => e.PolizaPropia)
                    .HasColumnName("poliza_propia")
                    .HasColumnType("enum('Si','No')");

                entity.Property(e => e.ProductoId)
                    .HasColumnName("producto_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ProximoPago)
                    .HasColumnName("proximo_pago")
                    .HasColumnType("date");

                entity.Property(e => e.RcUsaCanada)
                    .HasColumnName("rc_usa_canada")
                    .HasMaxLength(105)
                    .IsUnicode(false);

                entity.Property(e => e.ReciboPdf)
                    .HasColumnName("recibo_pdf")
                    .HasColumnType("longtext");

                entity.Property(e => e.TipoPoliza)
                    .HasColumnName("tipo_poliza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

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
                entity.ToTable("polizas_aseguradoras_no_agente", "brokfy_dev");

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
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasAseguradorasNoAgente)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_polizas_no_agente_usuarios");
            });

            modelBuilder.Entity<PolizasGadgets>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("polizas_gadgets", "brokfy_dev");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_gadgets_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasGadgets)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_gadgets");
            });

            modelBuilder.Entity<PolizasGastosMedicos>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("polizas_gastos_medicos", "brokfy_dev");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_gastos_medicos_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TipoPoliza)
                    .IsRequired()
                    .HasColumnName("tipo_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasGastosMedicos)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_gastos_medicos");
            });

            modelBuilder.Entity<PolizasHogar>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("polizas_hogar", "brokfy_dev");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_hogar_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasHogar)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_hogar");
            });

            modelBuilder.Entity<PolizasMascotas>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("polizas_mascotas", "brokfy_dev");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_mascotas_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasMascotas)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_mascotas");
            });

            modelBuilder.Entity<PolizasMoto>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("polizas_moto", "brokfy_dev");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_moto");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasMoto)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_moto");
            });

            modelBuilder.Entity<PolizasRc>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("polizas_rc", "brokfy_dev");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuarios_rc_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasRc)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_rc");
            });

            modelBuilder.Entity<PolizasViajes>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("polizas_viajes", "brokfy_dev");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PolizasVida>(entity =>
            {
                entity.HasKey(e => e.NoPoliza);

                entity.ToTable("polizas_vida", "brokfy_dev");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_usuario_vida_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasVida)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_vida");
            });

            modelBuilder.Entity<Preguntas>(entity =>
            {
                entity.ToTable("preguntas", "brokfy_dev");

                entity.HasIndex(e => e.TipoSeguroId)
                    .HasName("fk_preguntas_tipo_seguro1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasMaxLength(75)
                    .IsUnicode(false);

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
                entity.HasKey(e => new { e.Pregunta, e.IdPregunta });

                entity.ToTable("preguntas_chat", "brokfy_dev");

                entity.HasIndex(e => e.Id)
                    .HasName("chat_automoviles_idx");

                entity.HasIndex(e => e.IdHogar)
                    .HasName("chat_hogar_idx");

                entity.Property(e => e.Pregunta)
                    .HasColumnName("pregunta")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IdPregunta)
                    .HasColumnName("id_pregunta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdHogar)
                    .HasColumnName("id_hogar")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.PreguntasChat)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("chat_automoviles");

                entity.HasOne(d => d.IdHogarNavigation)
                    .WithMany(p => p.PreguntasChat)
                    .HasForeignKey(d => d.IdHogar)
                    .HasConstraintName("chat_hogar");
            });

            modelBuilder.Entity<PreguntasHogar>(entity =>
            {
                entity.ToTable("preguntasHogar", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("200");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRespuesta)
                    .HasColumnName("tipoRespuesta")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<PreguntasPerfil>(entity =>
            {
                entity.ToTable("preguntas_perfil", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRespuesta)
                    .HasColumnName("tipo_respuesta")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.ToTable("productos", "brokfy_dev");

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
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("xml");

                entity.Property(e => e.XmlEmision).HasColumnName("xml_emision");

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
                entity.ToTable("productos_brokfy", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasColumnName("producto")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profesiones>(entity =>
            {
                entity.ToTable("profesiones", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Propiedades>(entity =>
            {
                entity.ToTable("propiedades", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Salud>(entity =>
            {
                entity.ToTable("salud", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Siniestros>(entity =>
            {
                entity.HasKey(e => e.IdSiniestros);

                entity.ToTable("siniestros", "brokfy_dev");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_siniestros_usuarios_idx");

                entity.Property(e => e.IdSiniestros)
                    .HasColumnName("idSiniestros")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NoSiniestro)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Siniestros)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_siniestros_usuarios");
            });

            modelBuilder.Entity<Sotanos>(entity =>
            {
                entity.ToTable("sotanos", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .IsRequired()
                    .HasColumnName("etiqueta")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdChubb)
                    .HasColumnName("idChubb")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPoliza>(entity =>
            {
                entity.ToTable("tipo_poliza", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoSeguro>(entity =>
            {
                entity.ToTable("tipo_seguro", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Seguro)
                    .IsRequired()
                    .HasColumnName("seguro")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoTecho>(entity =>
            {
                entity.ToTable("tipo_techo", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("id_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdChubb)
                    .HasColumnName("id_chubb")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ValidadorAfirme)
                    .HasColumnName("validador_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ValorAfirme)
                    .HasColumnName("valor_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoViviendaBrokfy>(entity =>
            {
                entity.ToTable("tipo_vivienda_brokfy", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("id_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdChubb)
                    .HasColumnName("id_chubb")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ValidadorAfirme)
                    .HasColumnName("validador_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ValorAfirme)
                    .HasColumnName("valor_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposMuro>(entity =>
            {
                entity.ToTable("tipos_muro", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("id_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdChubb)
                    .HasColumnName("id_chubb")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ValidadorAfirme)
                    .HasColumnName("validador_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ValorAfirme)
                    .HasColumnName("valor_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tiposuelo>(entity =>
            {
                entity.HasKey(e => e.IdTipoSuelo);

                entity.ToTable("tiposuelo", "brokfy_dev");

                entity.Property(e => e.IdTipoSuelo)
                    .HasColumnName("idTipoSuelo")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsoVivienda>(entity =>
            {
                entity.ToTable("uso_vivienda", "brokfy_dev");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Etiqueta)
                    .HasColumnName("etiqueta")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdAfirme)
                    .HasColumnName("id_afirme")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Validador)
                    .HasColumnName("validador")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("usuario", "brokfy_dev");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Enabled)
                    .HasColumnName("enabled")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdConekta)
                    .HasColumnName("id_conekta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Intentos)
                    .HasColumnName("intentos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NameAws)
                    .HasColumnName("name_aws")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TokenF).HasColumnName("token_f");
            });

            modelBuilder.Entity<UsuariosToRoles>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.RoleId });

                entity.ToTable("usuarios_to_roles", "brokfy_dev");

                entity.HasIndex(e => e.RoleId)
                    .HasName("FK_ROLE_1_idx");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("FK_USUARIOS_1_idx");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

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
        }
    }
}
