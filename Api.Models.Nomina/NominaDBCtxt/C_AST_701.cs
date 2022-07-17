using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Api.Models.Nomina.NominaDBCtxt
{
    [Table("@AST_701")]
    public class C_AST_701
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

        public string U_CRP { get; set; }

        public string U_IMPEST { get; set; }

        public string U_ZSM { get; set; }

        public short? U_MPVAC { get; set; }

        public string U_ZONA { get; set; }

        public string U_FUNC { get; set; }

        public string U_DOM { get; set; }

        public string U_COL { get; set; }

        public string U_DEL { get; set; }

        public string U_EDO { get; set; }

        public string U_CODP { get; set; }

        public string U_NUMEXT { get; set; }

        public string U_NUMINT { get; set; }

        public string U_CRLOC1 { get; set; }

        [StringLength(50)]
        public string U_USUA { get; set; }

        [StringLength(50)]
        public string U_PASSA { get; set; }

        [StringLength(8)]
        public string U_CRLOC2 { get; set; }

        [StringLength(8)]
        public string U_CRLOC3 { get; set; }

        [StringLength(8)]
        public string U_CRLOC4 { get; set; }

        [StringLength(8)]
        public string U_SUCBSUC { get; set; }

        [StringLength(8)]
        public string U_CIA { get; set; }

        [StringLength(1)]
        public string U_OECTAB { get; set; }

        public short? U_EDADMIN { get; set; }
    }
}
