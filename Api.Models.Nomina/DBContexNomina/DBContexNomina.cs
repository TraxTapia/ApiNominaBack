using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{
    public class DBContexNomina : DbContext
    {
        private String Conn = string.Empty;

        public DBContexNomina(DbContextOptions<DBContexNomina> options, string _Conn)
            : base(options)
        {
            Conn = _Conn;

        }

        public DBContexNomina(string _Conn)
        {
            Conn = _Conn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Conn);
            var lf = new LoggerFactory();
            optionsBuilder.UseLoggerFactory(lf);
        }


        public virtual DbSet<CAT_APP> CAT_APP { get; set; }
        public virtual DbSet<CAT_ESTATUS_USR> CAT_ESTATUS_USR { get; set; }
        public virtual DbSet<CAT_ROL> CAT_ROL { get; set; }
        public virtual DbSet<GRUPO> GRUPO { get; set; }
        public virtual DbSet<GRUPO_OPCION_ACCION> GRUPO_OPCION_ACCION { get; set; }
        public virtual DbSet<GRUPO_OPCION_SECCION> GRUPO_OPCION_SECCION { get; set; }
        public virtual DbSet<GRUPO_PERMISO> GRUPO_PERMISO { get; set; }
        public virtual DbSet<GRUPO_ROL> GRUPO_ROL { get; set; }
        public virtual DbSet<GRUPO_URL_POST_APP> GRUPO_URL_POST_APP { get; set; }
        public virtual DbSet<GRUPO_USUARIO> GRUPO_USUARIO { get; set; }
        public virtual DbSet<MENSAJE_APP> MENSAJE_APP { get; set; }
        public virtual DbSet<MODULO_APP> MODULO_APP { get; set; }
        public virtual DbSet<OPCION_ACCION> OPCION_ACCION { get; set; }
        public virtual DbSet<OPCION_MODULO> OPCION_MODULO { get; set; }
        public virtual DbSet<OPCION_SECCION> OPCION_SECCION { get; set; }
        public virtual DbSet<ROL_OPCION> ROL_OPCION { get; set; }
        public virtual DbSet<URL_POST_APP> URL_POST_APP { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CAT_APP>()
                 .Property(e => e.nombre_app)
                 .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .Property(e => e.url_home)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .HasMany(e => e.CAT_ROL)
                .WithOne(e => e.CAT_APP)
                .HasForeignKey(e => e.id_app);

            //modelBuilder.Entity<CAT_APP>()
            //    .HasMany(e => e.CAT_ROL1)
            //    .WithOne(e => e.CAT_APP)
            //    .HasForeignKey(e => e.id_app);

            modelBuilder.Entity<CAT_APP>()
                .HasMany(e => e.MENSAJE_APP)
                .WithOne(e => e.CAT_APP)
                .HasForeignKey(e => e.id_app);

            modelBuilder.Entity<CAT_APP>()
                .HasMany(e => e.MODULO_APP)
                .WithOne(e => e.CAT_APP)
                .HasForeignKey(e => e.id_app);

            modelBuilder.Entity<CAT_APP>()
                .HasMany(e => e.URL_POST_APP)
                .WithOne(e => e.CAT_APP)
                .HasForeignKey(e => e.id_app);

            modelBuilder.Entity<CAT_ESTATUS_USR>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ESTATUS_USR>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ESTATUS_USR>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ESTATUS_USR>()
                .HasMany(e => e.USUARIO)
                .WithOne(e => e.CAT_ESTATUS_USR)
                .HasForeignKey(e => e.id_estatus_usr);

            modelBuilder.Entity<CAT_ROL>()
                .Property(e => e.rol)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ROL>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ROL>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ROL>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ROL>()
                .HasMany(e => e.GRUPO_PERMISO)
                .WithOne(e => e.CAT_ROL)
                .HasForeignKey(e => e.id_rol_opcion);

            modelBuilder.Entity<CAT_ROL>()
                .HasMany(e => e.GRUPO_ROL)
                .WithOne(e => e.CAT_ROL)
                .HasForeignKey(e => e.id_rol);

            modelBuilder.Entity<CAT_ROL>()
                .HasMany(e => e.MENSAJE_APP)
                .WithOne(e => e.CAT_ROL)
                .HasForeignKey(e => e.id_rol_origen);

            modelBuilder.Entity<CAT_ROL>()
                .HasMany(e => e.ROL_OPCION)
                .WithOne(e => e.CAT_ROL)
                .HasForeignKey(e => e.id_rol);

            modelBuilder.Entity<GRUPO>()
                .Property(e => e.grupo1)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO>()
                .HasMany(e => e.GRUPO_PERMISO)
                .WithOne(e => e.GRUPO)
                .HasForeignKey(e => e.id_grupo);

            modelBuilder.Entity<GRUPO>()
                .HasMany(e => e.GRUPO_ROL)
                .WithOne(e => e.GRUPO)
                .HasForeignKey(e => e.id_grupo);


            modelBuilder.Entity<GRUPO>()
                .HasMany(e => e.GRUPO_USUARIO)
                .WithOne(e => e.GRUPO)
                .HasForeignKey(e => e.id_grupo);

            modelBuilder.Entity<GRUPO_OPCION_ACCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_OPCION_ACCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_OPCION_SECCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_OPCION_SECCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_PERMISO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_PERMISO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_ROL>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_ROL>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_URL_POST_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_URL_POST_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_USUARIO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_USUARIO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<MENSAJE_APP>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<MENSAJE_APP>()
                .Property(e => e.json_data)
                .IsUnicode(false);

            modelBuilder.Entity<MENSAJE_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<MENSAJE_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.nombre_modulo)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.url_icono)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.url_destino)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .HasMany(e => e.OPCION_MODULO)
                .WithOne(e => e.MODULO_APP)
                .HasForeignKey(e => e.id_modulo);

            modelBuilder.Entity<OPCION_ACCION>()
                .Property(e => e.nombre_accion)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_ACCION>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_ACCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_ACCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_ACCION>()
                .HasMany(e => e.GRUPO_OPCION_ACCION)
                .WithOne(e => e.OPCION_ACCION)
                .HasForeignKey(e => e.id_accion)
               ;

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.descripcion_item)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.url_destino)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.url_icono)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .HasMany(e => e.OPCION_ACCION)
                .WithOne(e => e.OPCION_MODULO)
                .HasForeignKey(e => e.id_item_modulo)
               ;

            //modelBuilder.Entity<OPCION_MODULO>()
            //    .HasMany(e => e.OPCION_ACCION1)
            //    .WithOne(e => e.OPCION_MODULO1)
            //    .HasForeignKey(e => e.id_item_modulo)
            //   ;

            //modelBuilder.Entity<OPCION_MODULO>()
            //    .HasMany(e => e.OPCION_ACCION2)
            //    .WithOne(e => e.OPCION_MODULO2)
            //    .HasForeignKey(e => e.id_item_modulo)
            //   ;

            modelBuilder.Entity<OPCION_MODULO>()
                .HasMany(e => e.OPCION_SECCION)
                .WithOne(e => e.OPCION_MODULO)
                .HasForeignKey(e => e.id_item_modulo)
               ;

            modelBuilder.Entity<OPCION_MODULO>()
                .HasMany(e => e.ROL_OPCION)
                .WithOne(e => e.OPCION_MODULO)
                .HasForeignKey(e => e.id_item_modulo)
               ;

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.nombre_seccion)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.ui_grupo)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.json_params)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .HasMany(e => e.GRUPO_OPCION_SECCION)
                .WithOne(e => e.OPCION_SECCION)
                .HasForeignKey(e => e.id_modulo_seccion)
               ;

            modelBuilder.Entity<ROL_OPCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<ROL_OPCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<URL_POST_APP>()
                .Property(e => e.url_post)
                .IsUnicode(false);

            modelBuilder.Entity<URL_POST_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<URL_POST_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.llave_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.GRUPO_USUARIO)
                .WithOne(e => e.USUARIO)
                .HasForeignKey(e => e.id_usuario)
               ;
            modelBuilder.Entity<GRUPO_USUARIO>()
            .HasOne(p => p.USUARIO)
            .WithMany(b => b.GRUPO_USUARIO)
            .HasForeignKey(p => p.id_usuario)
            .HasPrincipalKey(b => b.Id);

            modelBuilder.Entity<GRUPO_USUARIO>()
          .HasOne(p => p.GRUPO)
          .WithMany(b => b.GRUPO_USUARIO)
          .HasForeignKey(p => p.id_grupo)
          .HasPrincipalKey(b => b.Id);

            modelBuilder.Entity<MODULO_APP>()
            .HasOne(p => p.CAT_APP)
            .WithMany(b => b.MODULO_APP)
            .HasForeignKey(p => p.id_app)
            .HasPrincipalKey(b => b.Id);

            modelBuilder.Entity<OPCION_MODULO>()
            .HasOne(p => p.MODULO_APP)
            .WithMany(b => b.OPCION_MODULO)
            .HasForeignKey(p => p.id_modulo)
            .HasPrincipalKey(b => b.Id);

            modelBuilder.Entity<CAT_ROL>()
            .HasOne(p => p.CAT_APP)
            .WithMany(b => b.CAT_ROL)
            .HasForeignKey(p => p.id_app)
            .HasPrincipalKey(b => b.Id);
            modelBuilder.Entity<OPCION_ACCION>()
          .HasOne(p => p.OPCION_MODULO)
          .WithMany(b => b.OPCION_ACCION)
          .HasForeignKey(p => p.id_item_modulo)
          .HasPrincipalKey(b => b.Id);

            
        }


    }
}
