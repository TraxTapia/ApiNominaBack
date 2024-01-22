namespace Bsase_Datos_Model.Nomina
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("@AST_722")]
    public partial class C_AST_722
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

        public string U_CIA { get; set; }

        public string U_CRDIR1 { get; set; }

        [StringLength(8)]
        public string U_LOC { get; set; }

        public string U_CRDIR2 { get; set; }

        public string U_CRDIR3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_IRD1 { get; set; }

        [StringLength(8)]
        public string U_CRDIR4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_IRD2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_IRD3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_IRD4 { get; set; }
    }
}
