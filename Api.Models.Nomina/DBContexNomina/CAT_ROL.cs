using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{
    [Table("CAT_ROL")]
    public partial class CAT_ROL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_ROL()
        {
            GRUPO_PERMISO = new HashSet<GRUPO_PERMISO>();
            GRUPO_ROL = new HashSet<GRUPO_ROL>();
            MENSAJE_APP = new HashSet<MENSAJE_APP>();
            ROL_OPCION = new HashSet<ROL_OPCION>();
        }
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string rol { get; set; }

        [Required]
        [StringLength(100)]
        public string descripcion { get; set; }

        public bool? activo { get; set; }

        public int id_app { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual CAT_APP CAT_APP { get; set; }

        //public virtual CAT_APP CAT_APP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_PERMISO> GRUPO_PERMISO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_ROL> GRUPO_ROL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENSAJE_APP> MENSAJE_APP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROL_OPCION> ROL_OPCION { get; set; }
    }
}
