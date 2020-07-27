using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReportesColgate.Models
{
    public partial class ColgateContext : DbContext
    {
        public ColgateContext()
        {
        }

        public ColgateContext(DbContextOptions<ColgateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DespensaFamiliar> DespensaFamiliar { get; set; }
        public virtual DbSet<EquivalenciaTablas> EquivalenciaTablas { get; set; }
        public virtual DbSet<FormatoPrecios> FormatoPrecios { get; set; }
        public virtual DbSet<MaxiDespensa> MaxiDespensa { get; set; }
        public virtual DbSet<Mercaderistas> Mercaderistas { get; set; }
        public virtual DbSet<Scoredcard> Scoredcard { get; set; }       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#/*warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.*/
                optionsBuilder.UseSqlServer("String de conexión aqui");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<DespensaFamiliar>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoEmpleado)
                    .HasColumnName("CODIGO_EMPLEADO")
                    .HasMaxLength(1);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("MARCA")
                    .HasMaxLength(50);

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Subcategoria)
                    .IsRequired()
                    .HasColumnName("SUBCATEGORIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("TIENDA")
                    .HasMaxLength(50);

                entity.Property(e => e.Upc).HasColumnName("UPC");

                entity.Property(e => e.UpcSinCod).HasColumnName("UPC_SIN_COD");
            });

            modelBuilder.Entity<EquivalenciaTablas>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Fieldlabel)
                    .IsRequired()
                    .HasColumnName("fieldlabel")
                    .HasMaxLength(100);

                entity.Property(e => e.Fieldname)
                    .IsRequired()
                    .HasColumnName("fieldname")
                    .HasMaxLength(50);

                entity.Property(e => e.Typeofdata)
                    .IsRequired()
                    .HasColumnName("typeofdata")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FormatoPrecios>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoEmpleado)
                    .IsRequired()
                    .HasColumnName("CODIGO_EMPLEADO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100);

                entity.Property(e => e.Indice).ValueGeneratedOnAdd();

                entity.Property(e => e.InicioSemana)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("MARCA")
                    .HasMaxLength(50);

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Subcategoria)
                    .IsRequired()
                    .HasColumnName("SUBCATEGORIA")
                    .HasMaxLength(50);

                entity.Property(e => e.TerminacionSemana)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("TIENDA")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Upc).HasColumnName("UPC");

                entity.Property(e => e.UpcSinCod).HasColumnName("UPC_SIN_COD");
            });

            modelBuilder.Entity<MaxiDespensa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("CATEGORIA")
                    .HasMaxLength(50);

                entity.Property(e => e.CodigoEmpleado)
                    .HasColumnName("CODIGO_EMPLEADO")
                    .HasMaxLength(1);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("MARCA")
                    .HasMaxLength(50);

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasColumnName("PROVEEDOR")
                    .HasMaxLength(50);

                entity.Property(e => e.Subcategoria)
                    .IsRequired()
                    .HasColumnName("SUBCATEGORIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Tienda)
                    .IsRequired()
                    .HasColumnName("TIENDA")
                    .HasMaxLength(50);

                entity.Property(e => e.Upc).HasColumnName("UPC");

                entity.Property(e => e.UpcSinCod).HasColumnName("UPC_SIN_COD");
            });

            modelBuilder.Entity<Mercaderistas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mercaderistas", "evo");

                entity.Property(e => e.CodigoEmpleado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreColaborador)
                    .IsRequired()
                    .HasColumnName("Nombre_colaborador")
                    .HasMaxLength(50);

                entity.Property(e => e.Puesto)
                    .IsRequired()
                    .HasColumnName("PUESTO")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Scoredcard>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Ac)
                    .HasColumnName("AC")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Anio)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ApoyoTienda)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasColumnName("BRAND_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CaCo3Cabecera)
                    .HasColumnName("CA-CO-3 CABECERA")
                    .IsUnicode(false);

                entity.Property(e => e.CaCo3Productos)
                    .HasColumnName("CA-CO-3 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.CaCp1Cabecera)
                    .HasColumnName("CA-CP-1 CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CaCp1CabeceraProductos)
                    .HasColumnName("CA-CP-1 CABECERA PRODUCTOS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CaHp4Cabecera)
                    .HasColumnName("CA-HP-4 CABECERA")
                    .IsUnicode(false);

                entity.Property(e => e.CaHp4Productos)
                    .HasColumnName("CA-HP-4 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.CaLh1Cabecera)
                    .HasColumnName("CA-LH-1 CABECERA")
                    .IsUnicode(false);

                entity.Property(e => e.CaLh1Productos)
                    .HasColumnName("CA-LH-1 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.CaLr1Cabecera)
                    .HasColumnName("CA-LR-1 CABECERA")
                    .IsUnicode(false);

                entity.Property(e => e.CaLr1Productos)
                    .HasColumnName("CA-LR-1 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.CaTemp2Cabecera)
                    .HasColumnName("CA-TEMP-2 CABECERA")
                    .IsUnicode(false);

                entity.Property(e => e.CaTemp2Productos)
                    .HasColumnName("CA-TEMP-2 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.CantidadIpsGestionadas)
                    .HasColumnName("Cantidad IPS Gestionadas")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Categoria)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CausasCepillosDientes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CausasCremasDentales)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CausasDesinfectantes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CausasDesodorantes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CausasEnjagueBucal)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CausasJabonesTocador)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CausasLavaplatos)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CausasShampoo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CausasSuavisantes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CoCkCpCaJaboncabecera)
                    .HasColumnName("CO-CK-CP-CA-JABONCABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CoCkImpulsoCajaProductos)
                    .HasColumnName("CO-CK-IMPULSO_CAJA---PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CoCkImpulsoCajalineal)
                    .HasColumnName("CO-CK-IMPULSO_CAJALINEAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CoSkProveedor3Cabecera)
                    .HasColumnName("CO-SK PROVEEDOR-3 CABECERA")
                    .IsUnicode(false);

                entity.Property(e => e.CoSkProveedor3Productos)
                    .HasColumnName("CO-SK PROVEEDOR-3 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.CodProv)
                    .HasColumnName("COD_PROV")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CortesCaja)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCaJabonProductos)
                    .HasColumnName("CP-CA-JABON   PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCaOral01Productos)
                    .HasColumnName("CP-CA-ORAL_01   PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCaOral01cabecera)
                    .HasColumnName("CP-CA-ORAL_01CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCaOral02Productos)
                    .HasColumnName("CP-CA-ORAL_02   PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCaOral02cabecera)
                    .HasColumnName("CP-CA-ORAL_02CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCaRazuradoProductos)
                    .HasColumnName("CP-CA-RAZURADO   PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCaRazuradocabecera)
                    .HasColumnName("CP-CA-RAZURADOCABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCremaDentEnjuagueACabProd)
                    .HasColumnName("CP-CREMA DENT - ENJUAGUE A CAB PROD")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCremaDentEnjuagueALinProd)
                    .HasColumnName("CP-CREMA DENT - ENJUAGUE A LIN PROD")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCremaDentEnjuagueBCabProd)
                    .HasColumnName("CP-CREMA DENT - ENJUAGUE B CAB PROD")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.CpCremaDentEnjuagueBLinProd)
                    .HasColumnName("CP-CREMA DENT - ENJUAGUE B LIN prod")
                    .IsUnicode(false);

                entity.Property(e => e.CpCremaDentEnjuagueBLineal)
                    .HasColumnName("CP-CREMA DENT ENJUAGUE B  LINEAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCremaDentEnjuagueacabecera)
                    .HasColumnName("CP-CREMA DENT-ENJUAGUEACABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCremadentEnjuagueBCabecera)
                    .HasColumnName("CP-CREMADENT-ENJUAGUE B CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpCremadentEnjuaguealineal)
                    .HasColumnName("CP-CREMADENT-ENJUAGUEALINEAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpGbOralProductos)
                    .HasColumnName("CP-GB-ORAL   PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpGbOralgondola)
                    .HasColumnName("CP-GB-ORALGONDOLA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpJabonLiqCremaDentACabProd)
                    .HasColumnName("CP-JABON LIQ.-CREMA DENT A CAB PROD")
                    .IsUnicode(false);

                entity.Property(e => e.CpJabonLiqCremaDentACabecera)
                    .HasColumnName("CP-JABON LIQ-CREMA DENT A  CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpJabonLiqCremaDentALinProd)
                    .HasColumnName("CP-JABON LIQ.-CREMA DENT A LIN PROD")
                    .IsUnicode(false);

                entity.Property(e => e.CpJabonLiqCremaDentALineal)
                    .HasColumnName("CP-JABON LIQ-CREMA DENT A  LINEAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpJabonLiqCremaDentBCabProd)
                    .HasColumnName("CP-JABON LIQ.-CREMA DENT B CAB PROD")
                    .IsUnicode(false);

                entity.Property(e => e.CpJabonLiqCremaDentBCabecera)
                    .HasColumnName("CP-JABON LIQ-CREMA DENT B  CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpJabonLiqCremaDentBLineal)
                    .HasColumnName("CP-JABON LIQ-CREMA DENT B  LINEAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CpJabonLiqCremaDentBLiqProd)
                    .HasColumnName("CP-JABON LIQ.-CREMA DENT B LIQ PROD")
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoCaCloroQuitProductos)
                    .HasColumnName("DO-CA-CLORO_QUIT   PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoCaCloroQuitcabecera)
                    .HasColumnName("DO-CA-CLORO_QUITCABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoCaLabaplatoscabecera)
                    .HasColumnName("DO-CA-LABAPLATOSCABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoCaLavaplatosProductos)
                    .HasColumnName("DO-CA-LAVAPLATOS   PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoCaLimpiadDesinfectProductos)
                    .HasColumnName("DO-CA-LIMPIAD_DESINFECT   PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoCaLimpiadDesinfectcabecera)
                    .HasColumnName("DO-CA-LIMPIAD_DESINFECTCABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoCloroDesinfectBCabProd)
                    .HasColumnName("DO-CLORO-DESINFECT B CAB PROD")
                    .IsUnicode(false);

                entity.Property(e => e.DoCloroDesinfectBCabecera)
                    .HasColumnName("DO-CLORO-DESINFECT B  CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoDetergenteDetLiqBCabProd)
                    .HasColumnName("DO-DETERGENTE-DET. LIQ. B CAB PROD")
                    .IsUnicode(false);

                entity.Property(e => e.DoDetergenteDetLiqBCabecera)
                    .HasColumnName("DO-DETERGENTE-DET.LIQ B  CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoDetergenteDetLiqBLinProd)
                    .HasColumnName("DO-DETERGENTE-DET. LIQ. B LIN PROD")
                    .IsUnicode(false);

                entity.Property(e => e.DoDetergenteDetLiqBLineal)
                    .HasColumnName("DO-DETERGENTE-DET.LIQ B  LINEAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoIsCloroProductos)
                    .HasColumnName("DO-IS-CLORO   PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoIsCloroisla)
                    .HasColumnName("DO-IS-CLOROISLA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoIsSuavisanteDetLiqCabecera)
                    .HasColumnName("DO-IS-SUAVISANTE-DET.LIQ  CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoIsSuavisanteDetLiqIsla)
                    .HasColumnName("DO-IS-SUAVISANTE-DET.LIQ  ISLA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoIsSuavisanteDetLiqLineal)
                    .HasColumnName("DO-IS-SUAVISANTE-DET.LIQ  LINEAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoIsSuavizanteDetLiqCabProd)
                    .HasColumnName("DO-IS-SUAVIZANTE-DET. LIQ. CAB PROD")
                    .IsUnicode(false);

                entity.Property(e => e.DoIsSuavizanteDetLiqIslaProd)
                    .HasColumnName("DO-IS-SUAVIZANTE-DET. LIQ. ISLA PROD")
                    .IsUnicode(false);

                entity.Property(e => e.DoIsSuavizanteDetLiqLinProd)
                    .HasColumnName("DO-IS-SUAVIZANTE-DET. LIQ.LIN PROD")
                    .IsUnicode(false);

                entity.Property(e => e.DoLimpiadLavaplatosBCabProd)
                    .HasColumnName("DO-LIMPIAD- LAVAPLATOS B CAB PROD")
                    .IsUnicode(false);

                entity.Property(e => e.DoLimpiadLavaplatosBCabecera)
                    .HasColumnName("DO-LIMPIAD-LAVAPLATOS B  CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DoLimpiadLavaplatosBLinProd)
                    .HasColumnName("DO-LIMPIAD- LAVAPLATOS B LIN PROD")
                    .IsUnicode(false);

                entity.Property(e => e.DoLimpiadLavaplatosBLineal)
                    .HasColumnName("DO-LIMPIAD-LAVAPLATOS B  LINEAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Espacio)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FallasCepillosDientes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FallasCremasDentales)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FallasDesinfectantes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FallasDesodorantes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FallasEnjagueBucal)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FallasJabonesTocador)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FallasLavaplatos)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FallasShampoo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FallasSuavisantes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FaltantesCepillosDeDientes)
                    .HasColumnName("Faltantes Cepillos de dientes")
                    .IsUnicode(false);

                entity.Property(e => e.FaltantesCremasDentales)
                    .HasColumnName("Faltantes Cremas Dentales")
                    .IsUnicode(false);

                entity.Property(e => e.FaltantesDesinfectantes)
                    .HasColumnName("Faltantes Desinfectantes")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FaltantesDesodorantes)
                    .HasColumnName("Faltantes Desodorantes")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FaltantesEnjuaguesBucales)
                    .HasColumnName("Faltantes Enjuagues Bucales")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FaltantesJabonesDeTocador)
                    .HasColumnName("Faltantes Jabones de Tocador")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FaltantesLavaplatos)
                    .HasColumnName("Faltantes Lavaplatos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FaltantesShampoos)
                    .HasColumnName("Faltantes Shampoos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FaltantesSuavisantes)
                    .HasColumnName("Faltantes Suavisantes")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFinTienda)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInicioTienda)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Formato)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Gestiones).IsUnicode(false);

                entity.Property(e => e.ImplementacionModularCudadoOcremasDentales)
                    .HasColumnName("ImplementacionModularCudadoOCremasDentales")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImplementacionModularCuidadoHdesinfectant)
                    .HasColumnName("ImplementacionModularCuidadoHDesinfectant")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImplementacionModularCuidadoHsuavisant)
                    .HasColumnName("ImplementacionModularCuidadoHSuavisant")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImplementacionModularCuidadoOcepillosDentas)
                    .HasColumnName("ImplementacionModularCuidadoOCepillosDentas")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImplementacionModularCuidadoOenjaguesBucal)
                    .HasColumnName("ImplementacionModularCuidadoOEnjaguesBucal")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImplementacionModularCuidadoPdesodorant)
                    .HasColumnName("ImplementacionModularCuidadoPDesodorant")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImplementacionModularCuidadoPjabonesTocad)
                    .HasColumnName("ImplementacionModularCuidadoPJabonesTocad")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImplementacionModularCuidadoPshamp)
                    .HasColumnName("ImplementacionModularCuidadoPShamp")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImplementacionModularLavaplat)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImpulsosCajasCoRetoEnCajas)
                    .HasColumnName("IMPULSOS CAJAS CO  RETO EN CAJAS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImpulsosCajasCoRetoEnCajasProd)
                    .HasColumnName("IMPULSOS CAJAS CO  RETO EN CAJAS PROD")
                    .IsUnicode(false);

                entity.Property(e => e.IndiceSc)
                    .HasColumnName("IndiceSC")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Isp10IslaPrimaria)
                    .HasColumnName("ISP-10 ISLA PRIMARIA")
                    .IsUnicode(false);

                entity.Property(e => e.Isp10Productos)
                    .HasColumnName("ISP-10 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.Isp16IslaPrimaria)
                    .HasColumnName("ISP-16 ISLA PRIMARIA")
                    .IsUnicode(false);

                entity.Property(e => e.Isp16Productos)
                    .HasColumnName("ISP-16 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.Iss2IslaSecundaria)
                    .HasColumnName("ISS-2 ISLA SECUNDARIA")
                    .IsUnicode(false);

                entity.Property(e => e.Iss2Productos)
                    .HasColumnName("ISS-2 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.Item)
                    .HasColumnName("item")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Limpieza)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LinealLineal)
                    .HasColumnName("LINEAL LINEAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LinealPrpductos)
                    .HasColumnName("LINEAL PRPDUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MedicionCms)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NomProv)
                    .HasColumnName("NOM_PROV")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTienda)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nomenclatura)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroTienda)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlCaCo3Cabecera)
                    .HasColumnName("PL-CA-CO-3 CABECERA")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlCaCo3Productos)
                    .HasColumnName("PL-CA-CO-3 PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlLateral9Lateral)
                    .HasColumnName("PL-LATERAL-9 LATERAL")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlLateral9LateralProductos)
                    .HasColumnName("PL-LATERAL-9 LATERAL PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentajeEspacio)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNo)
                    .HasColumnName("product_no")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Productid)
                    .HasColumnName("productid")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Productid1)
                    .HasColumnName("productid_1")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductosCHogarDesinfectantes)
                    .HasColumnName("Productos C. HogarDesinfectantes")
                    .IsUnicode(false);

                entity.Property(e => e.ProductosCHogarLavaplatos)
                    .HasColumnName("Productos C. HogarLavaplatos")
                    .IsUnicode(false);

                entity.Property(e => e.Programa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Reto01Productos)
                    .HasColumnName("RETO-01 PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.Reto01RetoEnCProductos)
                    .HasColumnName("RETO-01 RETO EN C. PRODUCTOS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Reto01RetoEnCaja)
                    .HasColumnName("RETO-01 RETO EN CAJA")
                    .IsUnicode(false);

                entity.Property(e => e.Reto01RetoEnCajas)
                    .HasColumnName("RETO-01 RETO EN CAJAS")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Subcategoria)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Supervisor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TabProductos)
                    .HasColumnName("TAB PRODUCTOS")
                    .IsUnicode(false);

                entity.Property(e => e.TabTab)
                    .HasColumnName("TAB TAB")
                    .IsUnicode(false);

                entity.Property(e => e.TiendaRotulacionCorrectaRollbacksGp)
                    .HasColumnName("TiendaRotulacionCorrectaRollbacksGP")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TiendaTieneTodosPreciadoresColocadosAct)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNbr)
                    .HasColumnName("VENDOR_NBR")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VndrName)
                    .HasColumnName("VNDR_NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
