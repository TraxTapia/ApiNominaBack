using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{

    public partial class OPCION_MODULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPCION_MODULO()
        {
            OPCION_ACCION = new HashSet<OPCION_ACCION>();
            OPCION_ACCION1 = new HashSet<OPCION_ACCION>();
            OPCION_ACCION2 = new HashSet<OPCION_ACCION>();
            OPCION_SECCION = new HashSet<OPCION_SECCION>();
            ROL_OPCION = new HashSet<ROL_OPCION>();
        }
        [Key]

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion_item { get; set; }

        [StringLength(255)]
        public string url_destino { get; set; }

        [StringLength(255)]
        public string url_icono { get; set; }

        public int id_item_padre { get; set; }

        public int id_modulo { get; set; }

        public bool activo { get; set; }

        public int orden { get; set; }

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

        public virtual MODULO_APP MODULO_APP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPCION_ACCION> OPCION_ACCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPCION_ACCION> OPCION_ACCION1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPCION_ACCION> OPCION_ACCION2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPCION_SECCION> OPCION_SECCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROL_OPCION> ROL_OPCION { get; set; }
    }
}
