using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.DBContexNomina
{
    public partial class CAT_APP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_APP()
        {
            CAT_ROL = new HashSet<CAT_ROL>();
            //CAT_ROL1 = new HashSet<CAT_ROL>();
            MENSAJE_APP = new HashSet<MENSAJE_APP>();
            MODULO_APP = new HashSet<MODULO_APP>();
            URL_POST_APP = new HashSet<URL_POST_APP>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_app { get; set; }

        [StringLength(150)]
        public string logo { get; set; }

        [StringLength(255)]
        public string url_home { get; set; }

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
        public virtual ICollection<CAT_ROL> CAT_ROL { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<CAT_ROL> CAT_ROL1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENSAJE_APP> MENSAJE_APP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MODULO_APP> MODULO_APP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<URL_POST_APP> URL_POST_APP { get; set; }
    }
}
