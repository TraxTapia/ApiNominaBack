using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{

    public partial class GRUPO_OPCION_SECCION
    {
        [Key]
        public int Id { get; set; }

        public int id_grupo { get; set; }

        public int id_item_modulo { get; set; }

        public int id_rol { get; set; }

        public int id_modulo_seccion { get; set; }

        public bool fl_permitir { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual OPCION_SECCION OPCION_SECCION { get; set; }
    }
}
