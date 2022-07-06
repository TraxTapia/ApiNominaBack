using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{

    public partial class OPCION_ACCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPCION_ACCION()
        {
            GRUPO_OPCION_ACCION = new HashSet<GRUPO_OPCION_ACCION>();
        }
        [Key]
        public int Id { get; set; }

        public int id_item_modulo { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_accion { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_OPCION_ACCION> GRUPO_OPCION_ACCION { get; set; }

        public virtual OPCION_MODULO OPCION_MODULO { get; set; }

        //public virtual OPCION_MODULO OPCION_MODULO1 { get; set; }

        //public virtual OPCION_MODULO OPCION_MODULO2 { get; set; }
    }
}
