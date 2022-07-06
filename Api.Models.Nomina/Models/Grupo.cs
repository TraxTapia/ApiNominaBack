using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace GRC.Autenticacion.Entidades
{
    [Table("GRUPO")]
    public class Grupo : EtidadBase 
    {
        private int _id_padre = 0;
        public int id_padre { get => _id_padre; set => _id_padre = value; }

        private String _grupo = String.Empty;
        public String grupo { get => _grupo; set => _grupo = value; }

        private Boolean _activo = false;
        public Boolean activo { get => _activo; set => _activo = value; }
    }
}
