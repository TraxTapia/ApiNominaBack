namespace Bsase_Datos_Model.Nomina
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    [Table("@AAST_010")]
    public partial class C_AAST_010
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LineId { get; set; }

        [StringLength(20)]
        public string Object { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogInst { get; set; }

        public string U_PAREN { get; set; }

        public DateTime? U_FNAC { get; set; }

        public string U_ECI { get; set; }

        public string U_SEX { get; set; }
    }
}
