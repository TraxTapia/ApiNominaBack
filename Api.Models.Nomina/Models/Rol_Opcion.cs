using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace GRC.Autenticacion.Entidades
{
    [Table("ROL_OPCION")]
    public class Rol_Opcion : EtidadBase 
    {
        private int _id_rol = 0;
        public int id_rol { get => _id_rol; set => _id_rol = value; }

        private int _id_item_modulo = 0;
        public int id_item_modulo { get => _id_item_modulo; set => _id_item_modulo = value; }
    }
}
