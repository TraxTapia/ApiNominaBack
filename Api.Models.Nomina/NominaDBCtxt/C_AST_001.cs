namespace Bsase_Datos_Model.Nomina
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table("@AST_001")]
    public partial class C_AST_001
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

        public string U_DCIA { get; set; }

        public string U_RFC { get; set; }

        public string U_ZSMC { get; set; }

        public string U_DGIRO { get; set; }

        public string U_RLEG { get; set; }

        public string U_RFCRL { get; set; }

        public string U_CURPRL { get; set; }

        public short? U_MPVAC { get; set; }

        public string U_DOM { get; set; }

        public string U_COL { get; set; }

        public string U_DEL { get; set; }

        public string U_EDO { get; set; }

        public string U_CODP { get; set; }

        public string U_NUMEXT { get; set; }

        public string U_NUMINT { get; set; }

        [StringLength(50)]
        public string U_USUA { get; set; }

        [StringLength(50)]
        public string U_PASSA { get; set; }
    }
}
