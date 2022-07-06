using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{
    [Table("USUARIO")]
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            GRUPO_USUARIO = new HashSet<GRUPO_USUARIO>();
        }
        [Key]
        public int Id { get; set; }

        [Column("usuario")]
        [Required]
        [StringLength(50)]
        public string usuario1 { get; set; }

        [Required]
        [StringLength(255)]
        public string llave_usuario { get; set; }

        public int id_estatus_usr { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_vencimiento_llave { get; set; }

        public int id_persona { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_registro { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual CAT_ESTATUS_USR CAT_ESTATUS_USR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRUPO_USUARIO> GRUPO_USUARIO { get; set; }
    }
}
