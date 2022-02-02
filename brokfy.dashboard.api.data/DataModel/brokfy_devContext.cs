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
        public virtual DbSet<ComisionActualModel> ComisionActualModels { get; set; }
        public virtual DbQuery<ReporteFacturacionTotal> ReporteFacturacionTotales { get; set; }
        public virtual DbQuery<ReporteComisiones> ReporteComisiones { get; set; }
        public virtual DbQuery<ReporteComisionesPendientes> ReporteComisionesPendientes { get; set; }
        public virtual DbQuery<ReportePolizasPorVencer> ReportePolizasPorVencer { get; set; }
        public virtual DbQuery<ReporteHistoricoPorcentajeComisiones> ReporteHistoricoPorcentajeComisiones { get; set; }
        public virtual DbQuery<ReportesPolizasBrokfyVsOtras> ReportesPolizasBrokfyVsOtras { get; set; }
        public virtual DbSet<PolizaPagoModel> PolizaPagoModels { get; set; }
        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<AnosMarca> AnosMarca { get; set; }
        public virtual DbSet<Aseguradoras> Aseguradoras { get; set; }
        public virtual DbSet<AseguradorasComisiones> AseguradorasComisiones { get; set; }
        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Bankcode> Bankcode { get; set; }
        public virtual DbSet<BankcodeAtlas> BankcodeAtlas { get; set; }
        public virtual DbSet<BeneficiariosVida> BeneficiariosVida { get; set; }
        public virtual DbSet<Bfroles> Bfroles { get; set; }
        public virtual DbSet<Bfroleusers> Bfroleusers { get; set; }
        public virtual DbSet<Bfusers> Bfusers { get; set; }
        public virtual DbSet<Cancelaciones> Cancelaciones { get; set; }
        public virtual DbSet<CantidadHijos> CantidadHijos { get; set; }
        public virtual DbSet<CartasNombramiento> CartasNombramiento { get; set; }
        public virtual DbSet<ChatAuto> ChatAuto { get; set; }
        public virtual DbSet<ChatAutomoviles> ChatAutomoviles { get; set; }
        public virtual DbSet<ChatBienvenida> ChatBienvenida { get; set; }
        public virtual DbSet<ChatHogar> ChatHogar { get; set; }
        public virtual DbSet<ChatHogar2> ChatHogar2 { get; set; }
        public virtual DbSet<ChatMoto> ChatMoto { get; set; }
        public virtual DbSet<ChatPyme> ChatPyme { get; set; }
        public virtual DbSet<ChatSubirPoliza> ChatSubirPoliza { get; set; }
        public virtual DbSet<ChatVida> ChatVida { get; set; }
        public virtual DbSet<ChatVida2> ChatVida2 { get; set; }
        public virtual DbSet<Coberturas> Coberturas { get; set; }
        public virtual DbSet<CoberturasPoliza> CoberturasPoliza { get; set; }
        public virtual DbSet<Codigospostales> Codigospostales { get; set; }
        public virtual DbSet<CorreosCancelacionAseguradoras> CorreosCancelacionAseguradoras { get; set; }
        public virtual DbSet<Descargables> Descargables { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<EstadoSiniestro> EstadoSiniestro { get; set; }
        public virtual DbSet<EstadosMexico> EstadosMexico { get; set; }
        public virtual DbSet<EstadosPolizas> EstadosPolizas { get; set; }
        public virtual DbSet<Gadgets> Gadgets { get; set; }
        public virtual DbSet<HistoricoDocumentos> HistoricoDocumentos { get; set; }
        public virtual DbSet<Hogar> Hogar { get; set; }
        public virtual DbSet<Identificaciones> Identificaciones { get; set; }
        public virtual DbSet<InsigniaCotizacion> InsigniaCotizacion { get; set; }
        public virtual DbSet<MarcasAseguradoras> MarcasAseguradoras { get; set; }
        public virtual DbSet<MedidasSeguridad> MedidasSeguridad { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MetodosPagoReg> MetodosPagoReg { get; set; }
        public virtual DbSet<ModelosAseguradoras> ModelosAseguradoras { get; set; }
        public virtual DbSet<ModelosMoto> ModelosMoto { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<NivelesCondominio> NivelesCondominio { get; set; }
        public virtual DbSet<Notificaciones> Notificaciones { get; set; }
        public virtual DbSet<NumeroAsegurado> NumeroAsegurado { get; set; }
        public virtual DbSet<Ocupaciones> Ocupaciones { get; set; }
        public virtual DbSet<OpcionesChat> OpcionesChat { get; set; }
        public virtual DbSet<OpcionesPerfilAsegurado> OpcionesPerfilAsegurado { get; set; }
        public virtual DbSet<OpcionesPerfilAsegurado2> OpcionesPerfilAsegurado2 { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<PagosDetalle> PagosDetalle { get; set; }
        public virtual DbSet<Parentesco> Parentesco { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<PerfilAsegurado> PerfilAsegurado { get; set; }
        public virtual DbSet<PerfilAseguradoHijosAsegurados> PerfilAseguradoHijosAsegurados { get; set; }
        public virtual DbSet<PerfilAseguradoSegurosPareja> PerfilAseguradoSegurosPareja { get; set; }
        public virtual DbSet<PerfilAseguradoVehiculos> PerfilAseguradoVehiculos { get; set; }
        public virtual DbSet<PisosCasas> PisosCasas { get; set; }
        public virtual DbSet<PolizaSiniestro> PolizaSiniestro { get; set; }
        public virtual DbSet<Polizas> Polizas { get; set; }
        public virtual DbSet<PolizasAseguradorasNoAgente> PolizasAseguradorasNoAgente { get; set; }
        public virtual DbSet<PolizasComisiones> PolizasComisiones { get; set; }
        public virtual DbSet<PolizasGastosMedicos> PolizasGastosMedicos { get; set; }
        public virtual DbSet<PolizasPorSubir> PolizasPorSubir { get; set; }
        public virtual DbSet<PolizasPorSubirPerfilAsegurado> PolizasPorSubirPerfilAsegurado { get; set; }
        public virtual DbSet<PolizasViajes> PolizasViajes { get; set; }
        public virtual DbSet<PolizasVida> PolizasVida { get; set; }
        public virtual DbSet<Preguntas> Preguntas { get; set; }
        public virtual DbSet<PreguntasAuto> PreguntasAuto { get; set; }
        public virtual DbSet<PreguntasBienvenida> PreguntasBienvenida { get; set; }
        public virtual DbSet<PreguntasChat> PreguntasChat { get; set; }
        public virtual DbSet<PreguntasChatHogar> PreguntasChatHogar { get; set; }
        public virtual DbSet<PreguntasChatVida> PreguntasChatVida { get; set; }
        public virtual DbSet<PreguntasHogar> PreguntasHogar { get; set; }
        public virtual DbSet<PreguntasMoto> PreguntasMoto { get; set; }
        public virtual DbSet<PreguntasPerfil> PreguntasPerfil { get; set; }
        public virtual DbSet<PreguntasPerfilAsegurado> PreguntasPerfilAsegurado { get; set; }
        public virtual DbSet<PreguntasPerfilToPerfiilAsegurado> PreguntasPerfilToPerfiilAsegurado { get; set; }
        public virtual DbSet<PreguntasSubirPoliza> PreguntasSubirPoliza { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<ProductosBrokfy> ProductosBrokfy { get; set; }
        public virtual DbSet<Profesiones> Profesiones { get; set; }
        public virtual DbSet<Propiedades> Propiedades { get; set; }
        public virtual DbSet<Pyme> Pyme { get; set; }
        public virtual DbSet<RegimenViviendas> RegimenViviendas { get; set; }
        public virtual DbSet<Reportes> Reportes { get; set; }
        public virtual DbSet<RestriccionesUsuarioMenu> RestriccionesUsuarioMenu { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Salud> Salud { get; set; }
        public virtual DbSet<SeguimientoSiniestro> SeguimientoSiniestro { get; set; }
        public virtual DbSet<Sexo> Sexo { get; set; }
        public virtual DbSet<Siniestros> Siniestros { get; set; }
        public virtual DbSet<Sotanos> Sotanos { get; set; }
        public virtual DbSet<TempFormaPago> TempFormaPago { get; set; }
        public virtual DbSet<TipoPoliza> TipoPoliza { get; set; }
        public virtual DbSet<TipoSeguro> TipoSeguro { get; set; }
        public virtual DbSet<TipoTecho> TipoTecho { get; set; }
        public virtual DbSet<TipoViviendaBrokfy> TipoViviendaBrokfy { get; set; }
        public virtual DbSet<TiposMuro> TiposMuro { get; set; }
        public virtual DbSet<UsoVivienda> UsoVivienda { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuariosToRoles> UsuariosToRoles { get; set; }
        public virtual DbSet<Vida> Vida { get; set; }
        public virtual DbSet<VwAseguradorasComisionesActuales> VwAseguradorasComisionesActuales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=database-1.cyu1bxjzzhpm.us-east-2.rds.amazonaws.com;port=3306;user=dev;password=DevBrokfy18;database=brokfy_produccion", x => x.ServerVersion("5.7.33-mysql"));
            }
        }

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

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasColumnName("logo")
                    .HasColumnType("text")
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

            modelBuilder.Entity<AseguradorasComisiones>(entity =>
            {
                entity.ToTable("aseguradoras_comisiones");

                entity.HasIndex(e => e.IdAseguradora)
                    .HasName("fk_aseguradoras_comisiones_aseguradoras_idx");

                entity.HasIndex(e => e.IdTipoPoliza)
                    .HasName("fk_aseguradoras_comisiones_tipo_polizas_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicioVigencia)
                    .HasColumnName("fecha_inicio_vigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAseguradora)
                    .HasColumnName("id_aseguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTipoPoliza)
                    .HasColumnName("id_tipo_poliza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.IdAseguradoraNavigation)
                    .WithMany(p => p.AseguradorasComisiones)
                    .HasForeignKey(d => d.IdAseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aseguradoras_comisiones_aseguradoras");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.AseguradorasComisiones)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_aseguradoras_comisiones_tipo_polizas");
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
                    .HasColumnType("varchar(150)")
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
                entity.HasKey(e => e.Banco)
                    .HasName("PRIMARY");

                entity.ToTable("bankcode");

                entity.Property(e => e.Banco)
                    .HasColumnName("banco")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodAna)
                    .HasColumnName("cod_ana")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodQualitas)
                    .HasColumnName("cod_qualitas")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CodZurich)
                    .HasColumnName("cod_zurich")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BankcodeAtlas>(entity =>
            {
                entity.HasKey(e => e.Clave)
                    .HasName("PRIMARY");

                entity.ToTable("bankcode_atlas");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Banco)
                    .HasColumnName("banco")
                    .HasColumnType("varchar(245)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BeneficiariosVida>(entity =>
            {
                entity.ToTable("beneficiarios_vida");

                entity.HasIndex(e => e.IdParentesco)
                    .HasName("fk_parentesco_beneficiario_idx");

                entity.HasIndex(e => e.NoPoliza)
                    .HasName("fk_beneficiarios_vida_vida_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.NoPoliza)
                    .IsRequired()
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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

            modelBuilder.Entity<Cancelaciones>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("cancelaciones");

                entity.HasIndex(e => e.IdAseguradora)
                    .HasName("fk_cancelaciones_aseguradora_idx");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdAseguradora)
                    .HasColumnName("id_aseguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("rfc")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlCartaCancelacion)
                    .IsRequired()
                    .HasColumnName("url_carta_cancelacion")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdAseguradoraNavigation)
                    .WithMany(p => p.Cancelaciones)
                    .HasForeignKey(d => d.IdAseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cancelaciones_aseguradora");

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithOne(p => p.Cancelaciones)
                    .HasForeignKey<Cancelaciones>(d => d.NoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cancelaciones_poliza");
            });

            modelBuilder.Entity<CantidadHijos>(entity =>
            {
                entity.ToTable("cantidad_hijos");

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

            modelBuilder.Entity<ChatAuto>(entity =>
            {
                entity.ToTable("chat_auto");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");
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

            modelBuilder.Entity<ChatBienvenida>(entity =>
            {
                entity.ToTable("chat_bienvenida");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");
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

            modelBuilder.Entity<ChatHogar2>(entity =>
            {
                entity.ToTable("chat_hogar_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChatMoto>(entity =>
            {
                entity.ToTable("chat_moto");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChatPyme>(entity =>
            {
                entity.ToTable("chat_pyme");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoRespuesta)
                    .HasColumnName("tipo_respuesta")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChatSubirPoliza>(entity =>
            {
                entity.ToTable("chat_subir_poliza");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
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

            modelBuilder.Entity<ChatVida2>(entity =>
            {
                entity.ToTable("chat_vida_2");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");
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

            modelBuilder.Entity<CoberturasPoliza>(entity =>
            {
                entity.HasKey(e => new { e.NoPoliza, e.Cobertura })
                    .HasName("PRIMARY");

                entity.ToTable("coberturas_poliza");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cobertura)
                    .HasColumnName("cobertura")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Deducible)
                    .HasColumnName("deducible")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SumaAsegurada)
                    .HasColumnName("suma_asegurada")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithMany(p => p.CoberturasPoliza)
                    .HasForeignKey(d => d.NoPoliza)
                    .HasConstraintName("fk_coberturas_poliza_polizas");
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

            modelBuilder.Entity<CorreosCancelacionAseguradoras>(entity =>
            {
                entity.HasKey(e => e.IdAseguradora)
                    .HasName("PRIMARY");

                entity.ToTable("correos_cancelacion_aseguradoras");

                entity.HasIndex(e => e.IdAseguradora)
                    .HasName("fk_correos_cancelacion_aseguradoras_aseguradoras_idx");

                entity.Property(e => e.IdAseguradora)
                    .HasColumnName("id_aseguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Copia)
                    .HasColumnName("copia")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasColumnName("correo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdAseguradoraNavigation)
                    .WithOne(p => p.CorreosCancelacionAseguradoras)
                    .HasForeignKey<CorreosCancelacionAseguradoras>(d => d.IdAseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_correos_cancelacion_aseguradoras_aseguradoras");
            });

            modelBuilder.Entity<Descargables>(entity =>
            {
                entity.HasKey(e => e.IdDescargable)
                    .HasName("PRIMARY");

                entity.ToTable("descargables");

                entity.HasIndex(e => e.Titulo)
                    .HasName("titulo_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Url)
                    .HasName("url_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdDescargable)
                    .HasColumnName("id_descargable")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(254)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(254)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Documentos>(entity =>
            {
                entity.ToTable("documentos");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_documentos_usuario_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Authority)
                    .HasColumnName("authority")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CrcSection)
                    .HasColumnName("crc_section")
                    .HasColumnType("varchar(45)")
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

                entity.Property(e => e.DocNumber)
                    .HasColumnName("doc_number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElectorId)
                    .HasColumnName("elector_id")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Emision)
                    .HasColumnName("emision")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Expeditor)
                    .HasColumnName("expeditor")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaExpiracion)
                    .HasColumnName("fecha_expiracion")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
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
                    .HasColumnName("foto_trasera")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Genero)
                    .HasColumnName("genero")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Locality)
                    .HasColumnName("locality")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LugarNacimiento)
                    .HasColumnName("lugar_nacimiento")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Municipality)
                    .HasColumnName("municipality")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("num_documento")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegistryYear)
                    .HasColumnName("registry_year")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Selfie)
                    .HasColumnName("selfie")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasColumnName("tipo_documento")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Documentos)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_documentos_usuario");
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

            modelBuilder.Entity<EstadoSiniestro>(entity =>
            {
                entity.HasKey(e => e.IdEstadoSiniestro)
                    .HasName("PRIMARY");

                entity.ToTable("estado_siniestro");

                entity.HasIndex(e => e.IdTipoPoliza)
                    .HasName("FK_ESTADO_SINIESTRO_TIPO_POLIZA_idx");

                entity.Property(e => e.IdEstadoSiniestro)
                    .HasColumnName("id_estado_siniestro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdTipoPoliza)
                    .HasColumnName("id_tipo_poliza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(254)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Orden)
                    .HasColumnName("orden")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.EstadoSiniestro)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESTADO_SINIESTRO_TIPO_POLIZA");
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

            modelBuilder.Entity<EstadosPolizas>(entity =>
            {
                entity.ToTable("estados_polizas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("nombre_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

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

            modelBuilder.Entity<HistoricoDocumentos>(entity =>
            {
                entity.ToTable("historico_documentos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Authority)
                    .HasColumnName("authority")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CrcSection)
                    .HasColumnName("crc_section")
                    .HasColumnType("varchar(45)")
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

                entity.Property(e => e.DocNumber)
                    .HasColumnName("doc_number")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElectorId)
                    .HasColumnName("elector_id")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Emision)
                    .HasColumnName("emision")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Expeditor)
                    .HasColumnName("expeditor")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaExpiracion)
                    .HasColumnName("fecha_expiracion")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
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
                    .HasColumnName("foto_trasera")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Genero)
                    .HasColumnName("genero")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Locality)
                    .HasColumnName("locality")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LugarNacimiento)
                    .HasColumnName("lugar_nacimiento")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Municipality)
                    .HasColumnName("municipality")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumDocumento)
                    .HasColumnName("num_documento")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegistryYear)
                    .HasColumnName("registry_year")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Selfie)
                    .HasColumnName("selfie")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasColumnName("tipo_documento")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Hogar>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("hogar");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FrenteMar).HasColumnName("frente_mar");

                entity.Property(e => e.IdTipoMuro)
                    .HasColumnName("id_tipo_muro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTipoTecho)
                    .HasColumnName("id_tipo_techo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTipoVivienda)
                    .HasColumnName("id_tipo_vivienda")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NivelesCasa)
                    .HasColumnName("niveles_casa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoPisosCondominio)
                    .HasColumnName("no_pisos_condominio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Piso)
                    .HasColumnName("piso")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sotanos)
                    .HasColumnName("sotanos")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithOne(p => p.Hogar)
                    .HasForeignKey<Hogar>(d => d.NoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_hogar_polizas");
            });

            modelBuilder.Entity<Identificaciones>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Tipo })
                    .HasName("PRIMARY");

                entity.ToTable("identificaciones");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FotoDelantera)
                    .HasColumnName("foto_delantera")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FotoTrasera)
                    .HasColumnName("foto_trasera")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Identificaciones)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IDENTIFICACIONES_USUARIO");
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

                entity.Property(e => e.ImportePagoFraccionado).HasColumnName("importe_pago_fraccionado");

                entity.Property(e => e.PrimaAnual).HasColumnName("prima_anual");

                entity.Property(e => e.PrimaDelRecibo).HasColumnName("prima_del_recibo");

                entity.Property(e => e.PrimaNeta).HasColumnName("prima_neta");

                entity.Property(e => e.SumaSeleccionada)
                    .IsRequired()
                    .HasColumnName("suma_seleccionada")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("varchar(45)")
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

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.IdMenu)
                    .HasName("PRIMARY");

                entity.ToTable("menu");

                entity.HasIndex(e => e.IdMenuPadre)
                    .HasName("FK_MENU_MENU_idx");

                entity.HasIndex(e => e.Ruta)
                    .HasName("ruta_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdMenu)
                    .HasColumnName("id_menu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Icono)
                    .HasColumnName("icono")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdMenuPadre)
                    .HasColumnName("id_menu_padre")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasColumnName("ruta")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdMenuPadreNavigation)
                    .WithMany(p => p.InverseIdMenuPadreNavigation)
                    .HasForeignKey(d => d.IdMenuPadre)
                    .HasConstraintName("FK_MENU_MENU");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PRIMARY");

                entity.ToTable("message");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageId)
                    .IsRequired()
                    .HasColumnName("message_id")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithOne(p => p.Message)
                    .HasForeignKey<Message>(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("message_usuario");
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

            modelBuilder.Entity<ModelosAseguradoras>(entity =>
            {
                entity.HasKey(e => new { e.CodModelo, e.AnioComercializacion })
                    .HasName("PRIMARY");

                entity.ToTable("modelos_aseguradoras");

                entity.HasIndex(e => e.Marcas)
                    .HasName("fk_modelos_aseguradoras_marcas_aseguradoras1_idx");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("cod_modelo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AnioComercializacion)
                    .HasColumnName("anio_comercializacion")
                    .HasColumnType("varchar(4)")
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
            });

            modelBuilder.Entity<ModelosMoto>(entity =>
            {
                entity.HasKey(e => new { e.CodModelo, e.AnioComercializacion })
                    .HasName("PRIMARY");

                entity.ToTable("modelos_moto");

                entity.Property(e => e.CodModelo)
                    .HasColumnName("cod_modelo")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AnioComercializacion)
                    .HasColumnName("anio_comercializacion")
                    .HasColumnType("varchar(145)")
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

            modelBuilder.Entity<Notificaciones>(entity =>
            {
                entity.ToTable("notificaciones");

                entity.HasIndex(e => e.NoPolizaAuto)
                    .HasName("fk_notificaciones_auto_idx");

                entity.HasIndex(e => e.NoPolizaHogar)
                    .HasName("fk_notificaciones_hogar_idx");

                entity.HasIndex(e => e.TipoPoliza)
                    .HasName("fk_notificaciones_tipo_poliza_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_notificacion_usuario_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body")
                    .HasColumnType("varchar(245)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Leido).HasColumnName("leido");

                entity.Property(e => e.NoPolizaAuto)
                    .HasColumnName("no_poliza_auto")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NoPolizaHogar)
                    .HasColumnName("no_poliza_hogar")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoPoliza)
                    .HasColumnName("tipo_poliza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasColumnType("varchar(245)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.NoPolizaAutoNavigation)
                    .WithMany(p => p.Notificaciones)
                    .HasForeignKey(d => d.NoPolizaAuto)
                    .HasConstraintName("fk_auto_notificaciones");

                entity.HasOne(d => d.NoPolizaHogarNavigation)
                    .WithMany(p => p.Notificaciones)
                    .HasForeignKey(d => d.NoPolizaHogar)
                    .HasConstraintName("fk_notificaciones_hogar");

                entity.HasOne(d => d.TipoPolizaNavigation)
                    .WithMany(p => p.Notificaciones)
                    .HasForeignKey(d => d.TipoPoliza)
                    .HasConstraintName("fk_notificaciones_tipo_poliza");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.NotificacionesNavigation)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_notificacion_usuario");
            });

            modelBuilder.Entity<NumeroAsegurado>(entity =>
            {
                entity.HasKey(e => new { e.IdAseguradora, e.Username })
                    .HasName("PRIMARY");

                entity.ToTable("numero_asegurado");

                entity.Property(e => e.IdAseguradora)
                    .HasColumnName("id_aseguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumAsegurado)
                    .IsRequired()
                    .HasColumnName("num_asegurado")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdAseguradoraNavigation)
                    .WithMany(p => p.NumeroAsegurado)
                    .HasForeignKey(d => d.IdAseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_num_asegurado_aseguradora");
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

            modelBuilder.Entity<OpcionesChat>(entity =>
            {
                entity.ToTable("opciones_chat");

                entity.HasIndex(e => e.IdChatAuto)
                    .HasName("opciones_chat_chat_auto_idx");

                entity.HasIndex(e => e.IdChatBienvenida)
                    .HasName("opciones_chat_chat_bienvenida_idx");

                entity.HasIndex(e => e.IdChatHogar2)
                    .HasName("opciones_chat_chat_hogar_2_idx");

                entity.HasIndex(e => e.IdChatMoto)
                    .HasName("opciones_chat_chat_moto_idx");

                entity.HasIndex(e => e.IdChatSubirPoliza)
                    .HasName("opciones_chat_chat_subir_poliza_idx");

                entity.HasIndex(e => e.IdChatVida2)
                    .HasName("opciones_chat_chat_vida_2_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Endpoint)
                    .HasColumnName("endpoint")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdChatAuto)
                    .HasColumnName("id_chat_auto")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.IdChatBienvenida)
                    .HasColumnName("id_chat_bienvenida")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.IdChatHogar2)
                    .HasColumnName("id_chat_hogar_2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdChatMoto)
                    .HasColumnName("id_chat_moto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdChatSubirPoliza)
                    .HasColumnName("id_chat_subir_poliza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdChatVida2)
                    .HasColumnName("id_chat_vida_2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Opcion)
                    .HasColumnName("opcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(145)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdChatAutoNavigation)
                    .WithMany(p => p.OpcionesChat)
                    .HasForeignKey(d => d.IdChatAuto)
                    .HasConstraintName("opciones_chat_chat_auto");

                entity.HasOne(d => d.IdChatBienvenidaNavigation)
                    .WithMany(p => p.OpcionesChat)
                    .HasForeignKey(d => d.IdChatBienvenida)
                    .HasConstraintName("opciones_chat_chat_bienvenida");

                entity.HasOne(d => d.IdChatHogar2Navigation)
                    .WithMany(p => p.OpcionesChat)
                    .HasForeignKey(d => d.IdChatHogar2)
                    .HasConstraintName("opciones_chat_chat_hogar_2");

                entity.HasOne(d => d.IdChatMotoNavigation)
                    .WithMany(p => p.OpcionesChat)
                    .HasForeignKey(d => d.IdChatMoto)
                    .HasConstraintName("opciones_chat_chat_moto");

                entity.HasOne(d => d.IdChatSubirPolizaNavigation)
                    .WithMany(p => p.OpcionesChat)
                    .HasForeignKey(d => d.IdChatSubirPoliza)
                    .HasConstraintName("opciones_chat_chat_subir_poliza");

                entity.HasOne(d => d.IdChatVida2Navigation)
                    .WithMany(p => p.OpcionesChat)
                    .HasForeignKey(d => d.IdChatVida2)
                    .HasConstraintName("opciones_chat_chat_vida_2");
            });

            modelBuilder.Entity<OpcionesPerfilAsegurado>(entity =>
            {
                entity.ToTable("opciones_perfil_asegurado");

                entity.HasIndex(e => e.IdPreguntaPerfil)
                    .HasName("fk_pregunta_perfil_opciones_perfil_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPreguntaPerfil)
                    .HasColumnName("id_pregunta_perfil")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Opcion)
                    .IsRequired()
                    .HasColumnName("opcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdPreguntaPerfilNavigation)
                    .WithMany(p => p.OpcionesPerfilAsegurado)
                    .HasForeignKey(d => d.IdPreguntaPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pregunta_perfil_opciones_perfil");
            });

            modelBuilder.Entity<OpcionesPerfilAsegurado2>(entity =>
            {
                entity.ToTable("opciones_perfil_asegurado_2");

                entity.HasIndex(e => e.IdPreguntaPerfilAsegurado)
                    .HasName("fk_opciones_preguntas_perfil_asegurado_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPreguntaPerfilAsegurado)
                    .HasColumnName("id_pregunta_perfil_asegurado")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Opcion)
                    .IsRequired()
                    .HasColumnName("opcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdPreguntaPerfilAseguradoNavigation)
                    .WithMany(p => p.OpcionesPerfilAsegurado2)
                    .HasForeignKey(d => d.IdPreguntaPerfilAsegurado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_opciones_preguntas_perfil_asegurado");
            });

            modelBuilder.Entity<Pagos>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                    .HasName("PRIMARY");

                entity.ToTable("pagos");

                entity.HasIndex(e => e.IdAseguradora)
                    .HasName("fk_pagos_aseguradoras_idx");

                entity.Property(e => e.IdPago)
                    .HasColumnName("id_pago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAseguradora)
                    .HasColumnName("id_aseguradora")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MetodoPago)
                    .HasColumnName("metodo_pago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdAseguradoraNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdAseguradora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pagos_aseguradoras");
            });

            modelBuilder.Entity<PagosDetalle>(entity =>
            {
                entity.HasKey(e => e.IdPagosDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("pagos_detalle");

                entity.HasIndex(e => e.IdPago)
                    .HasName("IX_PAGOS_DETALLE_ID_PAGO");

                entity.HasIndex(e => e.IdPolizaComision)
                    .HasName("FK_PAGOS_DETALLE_POLIZAS_COMISIONES_idx");

                entity.HasIndex(e => new { e.IdPago, e.IdPolizaComision })
                    .HasName("UQ_PAGOS_DETALLE")
                    .IsUnique();

                entity.Property(e => e.IdPagosDetalle)
                    .HasColumnName("id_pagos_detalle")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPago)
                    .HasColumnName("id_pago")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPolizaComision)
                    .HasColumnName("id_poliza_comision")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.Property(e => e.NoPoliza)
                    .IsRequired()
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.PagosDetalle)
                    .HasForeignKey(d => d.IdPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGOS_DETALLE_PAGOS");

                entity.HasOne(d => d.IdPolizaComisionNavigation)
                    .WithMany(p => p.PagosDetalle)
                    .HasForeignKey(d => d.IdPolizaComision)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PAGOS_DETALLE_POLIZAS_COMISIONES");
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

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Casado).HasColumnName("casado");

                entity.Property(e => e.DeportesRiesgo).HasColumnName("deportes_riesgo");

                entity.Property(e => e.Empresario).HasColumnName("empresario");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("date");

                entity.Property(e => e.Gmm).HasColumnName("gmm");

                entity.Property(e => e.Hijos)
                    .IsRequired()
                    .HasColumnName("hijos")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegimenVivienda)
                    .HasColumnName("regimen_vivienda")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SeguroAccidente).HasColumnName("seguro_accidente");

                entity.Property(e => e.SeguroHogar).HasColumnName("seguro_hogar");

                entity.Property(e => e.SeguroPyme).HasColumnName("seguro_pyme");

                entity.Property(e => e.SeguroRetiro).HasColumnName("seguro_retiro");

                entity.Property(e => e.SeguroViaje).HasColumnName("seguro_viaje");

                entity.Property(e => e.SeguroVida).HasColumnName("seguro_vida");

                entity.Property(e => e.Viaja).HasColumnName("viaja");
            });

            modelBuilder.Entity<PerfilAseguradoHijosAsegurados>(entity =>
            {
                entity.HasKey(e => new { e.Seguro, e.IdPerfil })
                    .HasName("PRIMARY");

                entity.ToTable("perfil_asegurado_hijos_asegurados");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("fk_perfil_asegurado_hijos_asegurados_idx");

                entity.Property(e => e.Seguro)
                    .HasColumnName("seguro")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilAseguradoHijosAsegurados)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_hijos_asegurados");
            });

            modelBuilder.Entity<PerfilAseguradoSegurosPareja>(entity =>
            {
                entity.HasKey(e => new { e.Seguro, e.IdPerfil })
                    .HasName("PRIMARY");

                entity.ToTable("perfil_asegurado_seguros_pareja");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("fk_perfil_asegurado_seguros_pareja_idx");

                entity.Property(e => e.Seguro)
                    .HasColumnName("seguro")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilAseguradoSegurosPareja)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_perfil_asegurado_seguros_pareja");
            });

            modelBuilder.Entity<PerfilAseguradoVehiculos>(entity =>
            {
                entity.HasKey(e => new { e.IdPerfil, e.Tipo })
                    .HasName("PRIMARY");

                entity.ToTable("perfil_asegurado_vehiculos");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("fk_vehiculo_perfil_asegurado_idx");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Asegurado).HasColumnName("asegurado");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PerfilAseguradoVehiculos)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vehiculo_perfil_asegurado");
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

            modelBuilder.Entity<PolizaSiniestro>(entity =>
            {
                entity.HasKey(e => e.IdPolizaSiniestro)
                    .HasName("PRIMARY");

                entity.ToTable("poliza_siniestro");

                entity.HasIndex(e => e.NoPoliza)
                    .HasName("FK_POLIZA_SINIESTRO_POLIZA_idx");

                entity.Property(e => e.IdPolizaSiniestro)
                    .HasColumnName("id_poliza_siniestro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Activo)
                    .HasColumnName("activo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FechaSiniestro)
                    .HasColumnName("fecha_siniestro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.NoPoliza)
                    .IsRequired()
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithMany(p => p.PolizaSiniestro)
                    .HasForeignKey(d => d.NoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POLIZA_SINIESTRO_POLIZA");
            });

            modelBuilder.Entity<Polizas>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("polizas");

                entity.HasIndex(e => e.IdAseguradoras)
                    .HasName("fk_polizas_aseguradoras1_idx");

                entity.HasIndex(e => e.IdEstadoPoliza)
                    .HasName("fk_polizas_estados_polizas_idx");

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

                entity.Property(e => e.IdEstadoPoliza)
                    .HasColumnName("id_estado_poliza")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

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

                entity.Property(e => e.PrimaNeta).HasColumnName("prima_neta");

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

                entity.HasOne(d => d.IdEstadoPolizaNavigation)
                    .WithMany(p => p.Polizas)
                    .HasForeignKey(d => d.IdEstadoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_estados_polizas_polizas");

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

            modelBuilder.Entity<PolizasComisiones>(entity =>
            {
                entity.HasKey(e => e.IdPolizaComision)
                    .HasName("PRIMARY");

                entity.ToTable("polizas_comisiones");

                entity.HasIndex(e => e.NoPoliza)
                    .HasName("IX_POLIZAS_COMISIONES_NO_POLIZA");

                entity.HasIndex(e => new { e.NoPoliza, e.Vencimiento })
                    .HasName("UQ_POLIZAS_COMISIONES")
                    .IsUnique();

                entity.Property(e => e.IdPolizaComision)
                    .HasColumnName("id_poliza_comision")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoPoliza)
                    .IsRequired()
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pagado).HasColumnName("pagado");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.Vencimiento)
                    .HasColumnName("vencimiento")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithMany(p => p.PolizasComisiones)
                    .HasForeignKey(d => d.NoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POLIZAS_COMISIONES_POLIZAS");
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

            modelBuilder.Entity<PolizasPorSubir>(entity =>
            {
                entity.ToTable("polizas_por_subir");

                entity.HasIndex(e => e.IdTipoPoliza)
                    .HasName("fk_polizas_por_subir_tipo_polizas_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("fk_polizas_por_subir_perfil_asegurado_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Activa).HasColumnName("activa");

                entity.Property(e => e.Fecha)
                    .IsRequired()
                    .HasColumnName("fecha")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaProximaAparicion)
                    .HasColumnName("fecha_proxima_aparicion")
                    .HasColumnType("date");

                entity.Property(e => e.IdTipoPoliza)
                    .HasColumnName("id_tipo_poliza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Subido).HasColumnName("subido");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdTipoPolizaNavigation)
                    .WithMany(p => p.PolizasPorSubir)
                    .HasForeignKey(d => d.IdTipoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_polizas_por_subir_tipo_polizas");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.PolizasPorSubir)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_polizas_por_subir_perfil_asegurado");
            });

            modelBuilder.Entity<PolizasPorSubirPerfilAsegurado>(entity =>
            {
                entity.ToTable("polizas_por_subir_perfil_asegurado");

                entity.HasIndex(e => e.IdPerfil)
                    .HasName("FK_POLIZAS_POR_SUBIR_PERFIL_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPerfil)
                    .IsRequired()
                    .HasColumnName("id_perfil")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UrlPoliza)
                    .IsRequired()
                    .HasColumnName("url_poliza")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.PolizasPorSubirPerfilAsegurado)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_POLIZAS_POR_SUBIR_PERFIL");
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

            modelBuilder.Entity<PreguntasAuto>(entity =>
            {
                entity.ToTable("preguntas_auto");

                entity.HasIndex(e => e.IdChatAuto)
                    .HasName("preguntas_auto_chat_auto_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdChatAuto)
                    .HasColumnName("id_chat_auto")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Pregunta)
                    .HasColumnName("pregunta")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdChatAutoNavigation)
                    .WithMany(p => p.PreguntasAuto)
                    .HasForeignKey(d => d.IdChatAuto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("preguntas_auto_chat_auto");
            });

            modelBuilder.Entity<PreguntasBienvenida>(entity =>
            {
                entity.ToTable("preguntas_bienvenida");

                entity.HasIndex(e => e.IdChatBienvenida)
                    .HasName("preguntas_bienvenida_chat_bienvenida_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdChatBienvenida)
                    .HasColumnName("id_chat_bienvenida")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdChatBienvenidaNavigation)
                    .WithMany(p => p.PreguntasBienvenida)
                    .HasForeignKey(d => d.IdChatBienvenida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("preguntas_bienvenida_chat_bienvenida");
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

                entity.HasIndex(e => e.IdPyme)
                    .HasName("fk_chat_pyme_idx");

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

                entity.Property(e => e.IdPyme)
                    .HasColumnName("id_pyme")
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

                entity.HasOne(d => d.IdPymeNavigation)
                    .WithMany(p => p.PreguntasChat)
                    .HasForeignKey(d => d.IdPyme)
                    .HasConstraintName("fk_chat_pyme");

                entity.HasOne(d => d.IdVidaNavigation)
                    .WithMany(p => p.PreguntasChat)
                    .HasForeignKey(d => d.IdVida)
                    .HasConstraintName("fk_chat_vida");
            });

            modelBuilder.Entity<PreguntasChatHogar>(entity =>
            {
                entity.ToTable("preguntas_chat_hogar");

                entity.HasIndex(e => e.IdChatHogar2)
                    .HasName("preguntas_chat_hogar_chat_hogar_2_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdChatHogar2)
                    .HasColumnName("id_chat_hogar_2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdChatHogar2Navigation)
                    .WithMany(p => p.PreguntasChatHogar)
                    .HasForeignKey(d => d.IdChatHogar2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("preguntas_chat_hogar_chat_hogar_2");
            });

            modelBuilder.Entity<PreguntasChatVida>(entity =>
            {
                entity.ToTable("preguntas_chat_vida");

                entity.HasIndex(e => e.IdChatVida)
                    .HasName("preguntas_chat_vida_chat_vida_2_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdChatVida)
                    .HasColumnName("id_chat_vida")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdChatVidaNavigation)
                    .WithMany(p => p.PreguntasChatVida)
                    .HasForeignKey(d => d.IdChatVida)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("preguntas_chat_vida_chat_vida_2");
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

            modelBuilder.Entity<PreguntasMoto>(entity =>
            {
                entity.ToTable("preguntas_moto");

                entity.HasIndex(e => e.IdChatMoto)
                    .HasName("fk_preguntas_moto_chat_moto_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdChatMoto)
                    .HasColumnName("id_chat_moto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pregunta)
                    .HasColumnName("pregunta")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdChatMotoNavigation)
                    .WithMany(p => p.PreguntasMoto)
                    .HasForeignKey(d => d.IdChatMoto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_preguntas_moto_chat_moto");
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

                entity.Property(e => e.RespuestaMultiple).HasColumnName("respuesta_multiple");

                entity.Property(e => e.Seccion)
                    .HasColumnName("seccion")
                    .HasColumnType("int(1)");
            });

            modelBuilder.Entity<PreguntasPerfilAsegurado>(entity =>
            {
                entity.ToTable("preguntas_perfil_asegurado");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Omitir)
                    .HasColumnName("omitir")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RespuestaMultiple).HasColumnName("respuesta_multiple");

                entity.Property(e => e.SabiasQue)
                    .IsRequired()
                    .HasColumnName("sabias_que")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Seccion)
                    .HasColumnName("seccion")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PreguntasPerfilToPerfiilAsegurado>(entity =>
            {
                entity.HasKey(e => new { e.PreguntasPerfilId, e.PerfilAseguradoId })
                    .HasName("PRIMARY");

                entity.ToTable("preguntas_perfil_to_perfiil_asegurado");

                entity.HasIndex(e => e.PerfilAseguradoId)
                    .HasName("fk_preguntas_perfil_to_perfila_asegurado_idx");

                entity.Property(e => e.PreguntasPerfilId)
                    .HasColumnName("preguntas_perfil_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PerfilAseguradoId)
                    .HasColumnName("perfil_asegurado_id")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.PerfilAsegurado)
                    .WithMany(p => p.PreguntasPerfilToPerfiilAsegurado)
                    .HasForeignKey(d => d.PerfilAseguradoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_preguntas_perfil_to_perfila_asegurado");

                entity.HasOne(d => d.PreguntasPerfil)
                    .WithMany(p => p.PreguntasPerfilToPerfiilAsegurado)
                    .HasForeignKey(d => d.PreguntasPerfilId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_preguntas_perfil_to_preguntas_perfil");
            });

            modelBuilder.Entity<PreguntasSubirPoliza>(entity =>
            {
                entity.ToTable("preguntas_subir_poliza");

                entity.HasIndex(e => e.IdChatSubirPoliza)
                    .HasName("preguntas_subir_poliza_chat_subir_poliza_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Anexos)
                    .HasColumnName("anexos")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdChatSubirPoliza)
                    .HasColumnName("id_chat_subir_poliza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pregunta)
                    .HasColumnName("pregunta")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdChatSubirPolizaNavigation)
                    .WithMany(p => p.PreguntasSubirPoliza)
                    .HasForeignKey(d => d.IdChatSubirPoliza)
                    .HasConstraintName("preguntas_subir_poliza_chat_subir_poliza");
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

            modelBuilder.Entity<Pyme>(entity =>
            {
                entity.HasKey(e => e.NoPoliza)
                    .HasName("PRIMARY");

                entity.ToTable("pyme");

                entity.Property(e => e.NoPoliza)
                    .HasColumnName("no_poliza")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CantidadNiveles)
                    .HasColumnName("cantidad_niveles")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CercaMar)
                    .IsRequired()
                    .HasColumnName("cerca_mar")
                    .HasColumnType("enum('Si','No')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Giro)
                    .IsRequired()
                    .HasColumnName("giro")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("razon_social")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("rfc")
                    .HasColumnType("varchar(14)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subgiro)
                    .IsRequired()
                    .HasColumnName("subgiro")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoMuro)
                    .IsRequired()
                    .HasColumnName("tipo_muro")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoTecho)
                    .IsRequired()
                    .HasColumnName("tipo_techo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.NoPolizaNavigation)
                    .WithOne(p => p.Pyme)
                    .HasForeignKey<Pyme>(d => d.NoPoliza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_polizas_pyme");
            });

            modelBuilder.Entity<RegimenViviendas>(entity =>
            {
                entity.ToTable("regimen_viviendas");

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

            modelBuilder.Entity<Reportes>(entity =>
            {
                entity.HasKey(e => e.IdReporte)
                    .HasName("PRIMARY");

                entity.ToTable("reportes");

                entity.Property(e => e.IdReporte)
                    .HasColumnName("id_reporte")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<RestriccionesUsuarioMenu>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.IdMenu })
                    .HasName("PRIMARY");

                entity.ToTable("restricciones_usuario_menu");

                entity.HasIndex(e => e.IdMenu)
                    .HasName("FK_RESTRICCIONES_USUARIO_MENU_MENU_idx");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdMenu)
                    .HasColumnName("id_menu")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdMenuNavigation)
                    .WithMany(p => p.RestriccionesUsuarioMenu)
                    .HasForeignKey(d => d.IdMenu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESTRICCIONES_USUARIO_MENU_MENU");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.RestriccionesUsuarioMenu)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESTRICCIONES_USUARIO_MENU_USUARIO");
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

            modelBuilder.Entity<SeguimientoSiniestro>(entity =>
            {
                entity.HasKey(e => e.IdSeguimientoSiniestro)
                    .HasName("PRIMARY");

                entity.ToTable("seguimiento_siniestro");

                entity.HasIndex(e => e.IdEstadoSiniestro)
                    .HasName("FK_SEGUIMIENTO_SINIESTRO_ESTADO_SINIESTRO_idx");

                entity.HasIndex(e => e.IdPolizaSiniestro)
                    .HasName("FK_SEGUIMIENTO_SINIESTRO_POLIZA_SINIESTRO_idx");

                entity.HasIndex(e => e.Username)
                    .HasName("FK_SEGUIMIENTO_SINIESTRO_USUARIO_idx");

                entity.Property(e => e.IdSeguimientoSiniestro)
                    .HasColumnName("id_seguimiento_siniestro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnName("comentario")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("' '")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.IdEstadoSiniestro)
                    .HasColumnName("id_estado_siniestro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPolizaSiniestro)
                    .HasColumnName("id_poliza_siniestro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdEstadoSiniestroNavigation)
                    .WithMany(p => p.SeguimientoSiniestro)
                    .HasForeignKey(d => d.IdEstadoSiniestro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEGUIMIENTO_SINIESTRO_ESTADO_SINIESTRO");

                entity.HasOne(d => d.IdPolizaSiniestroNavigation)
                    .WithMany(p => p.SeguimientoSiniestro)
                    .HasForeignKey(d => d.IdPolizaSiniestro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEGUIMIENTO_SINIESTRO_POLIZA_SINIESTRO");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.SeguimientoSiniestro)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEGUIMIENTO_SINIESTRO_USUARIO");
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

            modelBuilder.Entity<TempFormaPago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago)
                    .HasName("PRIMARY");

                entity.ToTable("temp_forma_pago");

                entity.Property(e => e.IdFormaPago)
                    .HasColumnName("id_forma_pago")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FormaPago)
                    .HasColumnName("forma_pago")
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

                entity.Property(e => e.Habilitada).HasColumnName("habilitada");

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

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

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

                entity.Property(e => e.Notificaciones)
                    .HasColumnName("notificaciones")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Online)
                    .HasColumnName("online")
                    .HasDefaultValueSql("'0'");

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

            modelBuilder.Entity<VwAseguradorasComisionesActuales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAseguradorasComisionesActuales");

                entity.Property(e => e.IdAseguradora)
                    .HasColumnName("id_aseguradora")
                    .HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
