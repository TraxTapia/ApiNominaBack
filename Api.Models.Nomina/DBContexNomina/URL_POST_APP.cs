using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{
    public partial class URL_POST_APP
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(1024)]
        public string url_post { get; set; }

        public int id_app { get; set; }

        public bool? activo { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual CAT_APP CAT_APP { get; set; }
    }
}
