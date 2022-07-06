using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations.Schema;
namespace GRC.Autenticacion.Entidades
{
    [Table("GRUPO_PERMISO")]
    public class Grupo_Permiso : EtidadBase 
    {
        private int _id_grupo = 0;
        public int id_grupo { get => _id_grupo; set => _id_grupo = value; }

        private int _id_rol_opcion = 0;
        public int id_rol_opcion { get => _id_rol_opcion; set => _id_rol_opcion = value; }

        private Boolean _fl_write = false;
        public Boolean fl_write { get => _fl_write; set => _fl_write = value; }

        private Boolean _fl_delete = false;
        public Boolean fl_delete { get => _fl_delete; set => _fl_delete = value; }

    }
}
