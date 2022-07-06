using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{
    [Table("GRUPO")]
    public partial class GRUPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRUPO()
        {
            GRUPO_PERMISO = new HashSet<GRUPO_PERMISO>();
            GRUPO_ROL = new HashSet<GRUPO_ROL>();
            GRUPO_USUARIO = new HashSet<GRUPO_USUARIO>();
        }
        [Key]
        public int Id { get; set; }

        public int id_padre { get; set; }

        [Column("grupo")]
        [Required]
        [StringLength(50)]
        public string grupo1 { get; set; }

        public bool activo { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_PERMISO> GRUPO_PERMISO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_ROL> GRUPO_ROL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_USUARIO> GRUPO_USUARIO { get; set; }
    }
}
