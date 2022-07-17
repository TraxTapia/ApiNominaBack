namespace Bsase_Datos_Model.Nomina
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("@AST_702")]
    public partial class C_AST_702
    {
        [Key]
        [StringLength(8)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int DocEntry { get; set; }

        [StringLength(1)]
        public string Canceled { get; set; }

        [StringLength(20)]
        public string Object { get; set; }

        public int? LogInst { get; set; }

        public int? UserSign { get; set; }

        [StringLength(1)]
        public string Transfered { get; set; }

        public DateTime? CreateDate { get; set; }

        public short? CreateTime { get; set; }

        public DateTime? UpdateDate { get; set; }

        public short? UpdateTime { get; set; }

        [StringLength(1)]
        public string DataSource { get; set; }

        public short? U_NTB { get; set; }

        public string U_PUES { get; set; }

        public string U_NIVJ { get; set; }

        [StringLength(8)]
        public string U_CRPUE1 { get; set; }

        [StringLength(8)]
        public string U_DEP { get; set; }

        [StringLength(1)]
        public string U_ACCTAB { get; set; }

        [StringLength(8)]
        public string U_TNO { get; set; }

        [StringLength(8)]
        public string U_TUR { get; set; }

        [StringLength(8)]
        public string U_CRPUE2 { get; set; }

        [StringLength(8)]
        public string U_CRPUE3 { get; set; }

        [StringLength(8)]
        public string U_CRPUE4 { get; set; }

        public short? U_EDADMIN { get; set; }

        [StringLength(10)]
        public string U_STATMOPER { get; set; }
    }
}
