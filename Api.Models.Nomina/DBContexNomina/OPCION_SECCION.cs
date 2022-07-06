using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{
    public partial class OPCION_SECCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPCION_SECCION()
        {
            GRUPO_OPCION_SECCION = new HashSet<GRUPO_OPCION_SECCION>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_seccion { get; set; }

        public int id_item_modulo { get; set; }

        public bool activo { get; set; }

        [Required]
        [StringLength(14)]
        public string version { get; set; }

        [Required]
        [StringLength(25)]
        public string ui_grupo { get; set; }

        [Required]
        [StringLength(500)]
        public string json_params { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_OPCION_SECCION> GRUPO_OPCION_SECCION { get; set; }

        public virtual OPCION_MODULO OPCION_MODULO { get; set; }
    }
}
