namespace Bsase_Datos_Model.Nomina
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("@AST_703")]
    public partial class C_AST_703
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

        public string U_ACCVC { get; set; }

        public string U_ACCREN { get; set; }

        public string U_TD { get; set; }

        public string U_PAB { get; set; }

        public string U_PRP { get; set; }

        public string U_PBAJ { get; set; }

        public short? U_PMME { get; set; }

        public string U_NTNO { get; set; }

        public short? U_LIMAUS { get; set; }

        public string U_SEMP { get; set; }

        public string U_GPOL { get; set; }

        public string U_GORD { get; set; }

        public string U_STTNOU { get; set; }

        public string U_INCSIM { get; set; }

        public string U_TNOE { get; set; }

        public string U_STATE { get; set; }

        [StringLength(1)]
        public string U_OECTAB { get; set; }

        [StringLength(1)]
        public string U_UCTAB2 { get; set; }
    }
}
