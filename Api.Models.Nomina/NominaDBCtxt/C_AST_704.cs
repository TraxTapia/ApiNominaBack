﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Api.Models.Nomina.NominaDBCtxt
{
    [Table("@AST_704")]
    public class C_AST_704
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

        public string U_NCAT { get; set; }
    }
}
