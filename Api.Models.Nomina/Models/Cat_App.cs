using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GRC.Autenticacion.Entidades
{
    
    [Table("CAT_APP")]
    public class Cat_App : EtidadBase
    { 
        private String _nombre_app = String.Empty;
        public String nombre_app { get => _nombre_app; set => _nombre_app = value; }

        private String _logo = String.Empty;
        public String logo { get => _logo; set => _logo = value; }

        private String _url_home = String.Empty;
        public String url_home { get => _url_home; set => _url_home = value; }

        private Boolean _activo = false;
        public Boolean activo { get => _activo; set => _activo = value; }
    
    }
}
