using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{

    public partial class GRUPO_ROL
    {
        [Key]
        public int Id { get; set; }

        public int id_rol { get; set; }

        public int id_grupo { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual CAT_ROL CAT_ROL { get; set; }

        public virtual GRUPO GRUPO { get; set; }
    }
}
