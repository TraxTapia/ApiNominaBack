using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace GRC.Autenticacion.Entidades
{
    [Table("CAT_ROL")]
    public class Cat_Rol: EtidadBase
    {
        private String _rol = String.Empty;
        public String rol { get => _rol; set => _rol = value; }

        private String _descripcion = String.Empty;
        public String descripcion { get => _descripcion; set => _descripcion = value; }

        private Boolean _activo = false;
        public Boolean activo { get => _activo; set => _activo = value; }

        private int _id_app = 0;
        public int id_app { get => _id_app; set => _id_app = value; }
    }
}
