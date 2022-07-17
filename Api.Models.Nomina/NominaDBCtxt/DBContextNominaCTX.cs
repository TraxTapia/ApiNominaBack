using Bsase_Datos_Model.Nomina;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Models.Nomina.NominaDBCtxt
{
    public  class DBContextNominaCTX : DbContext
    {
        private String Conn = string.Empty;

        public DBContextNominaCTX(DbContextOptions<DBContextNominaCTX> options, string _Conn)
            : base(options)
        {
            Conn = _Conn;

        }

        public DBContextNominaCTX(string _Conn)
        {
            Conn = _Conn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Conn);
            var lf = new LoggerFactory();
            optionsBuilder.UseLoggerFactory(lf);
        }
        public virtual DbSet<C_AAST_010> C_AAST_010 { get; set; }
        public virtual DbSet<C_AST_001> C_AST_001 { get; set; }
        public virtual DbSet<C_AST_010> C_AST_010 { get; set; }
        public virtual DbSet<C_AST_011> C_AST_011 { get; set; }
        public virtual DbSet<C_AST_132> C_AST_132 { get; set; }
        public virtual DbSet<C_AST_142> C_AST_142 { get; set; }
        public virtual DbSet<C_AST_701> C_AST_701 { get; set; }
        public virtual DbSet<C_AST_702> C_AST_702 { get; set; }
        public virtual DbSet<C_AST_703> C_AST_703 { get; set; }
        public virtual DbSet<C_AST_704> C_AST_704 { get; set; }
        public virtual DbSet<C_AST_705> C_AST_705 { get; set; }
        public virtual DbSet<C_AST_706> C_AST_706 { get; set; }
        public virtual DbSet<C_AST_708> C_AST_708 { get; set; }
        public virtual DbSet<C_AST_709> C_AST_709 { get; set; }
        public virtual DbSet<C_AST_710> C_AST_710 { get; set; }
        public virtual DbSet<C_AST_711> C_AST_711 { get; set; }
        public virtual DbSet<C_AST_712> C_AST_712 { get; set; }
        public virtual DbSet<C_AST_713> C_AST_713 { get; set; }
        public virtual DbSet<C_AST_714> C_AST_714 { get; set; }
        public virtual DbSet<C_AST_715> C_AST_715 { get; set; }
        public virtual DbSet<C_AST_716> C_AST_716 { get; set; }
        public virtual DbSet<C_AST_717> C_AST_717 { get; set; }
        public virtual DbSet<C_AST_718> C_AST_718 { get; set; }
        public virtual DbSet<C_AST_722> C_AST_722 { get; set; }
        public virtual DbSet<C_AST_723> C_AST_723 { get; set; }
        public virtual DbSet<C_AST_737> C_AST_737 { get; set; }
        public virtual DbSet<C_AST_747> C_AST_747 { get; set; }
        public virtual DbSet<C_AST_754> C_AST_754 { get; set; }
        public virtual DbSet<C_AST_F11> C_AST_F11 { get; set; }
        public virtual DbSet<C_AST_T12> C_AST_T12 { get; set; }
        public virtual DbSet<C_AST_T15> C_AST_T15 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_AST_011>().HasKey(x => new { x.Code, x.LogInst });
            modelBuilder.Entity<C_AAST_010>().HasKey(x => new { x.Code, x.LogInst ,x.LineId});
            modelBuilder.Entity<C_AST_010>().HasKey(x => new { x.Code, x.LogInst ,x.LineId});
            modelBuilder.Entity<C_AST_T15>().HasKey(x => new { x.Code, x.LineId});
            modelBuilder.Entity<C_AST_T12>().HasKey(x => new { x.Code, x.LineId});


            modelBuilder.Entity<C_AST_001>()
                 .Property(e => e.Canceled)
                 .IsFixedLength()
                 .IsUnicode(false);

            modelBuilder.Entity<C_AST_001>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_001>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_STAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SUE);
              

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SDI);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SIST);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SFIJ);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SVAR);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_INTF);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_IRE1);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_IRE2);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_BONO);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SN);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SPRO);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_DBANT);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_VBANT);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_PTJAUM);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SUED);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_IFV);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_CALFN);


            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_STATN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_TIPUSU)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
