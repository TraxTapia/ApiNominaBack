using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{

    public partial class MODULO_APP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MODULO_APP()
        {
            OPCION_MODULO = new HashSet<OPCION_MODULO>();
        }
        [Key]

        public int Id { get; set; }

        public int id_padre { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_modulo { get; set; }

        [StringLength(255)]
        public string url_icono { get; set; }

        [StringLength(255)]
        public string url_destino { get; set; }

        public int id_app { get; set; }

        public bool activo { get; set; }

        [Required]
        [StringLength(14)]
        public string version { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual CAT_APP CAT_APP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPCION_MODULO> OPCION_MODULO { get; set; }
    }
}
