using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace GRC.Autenticacion.Entidades
{
    [Table("OPCION_MODULO")]
    public class Opcion_Modulo : EtidadBase
    {
        private String _descripcion_item = String.Empty;
        public String descripcion_item { get => _descripcion_item; set => _descripcion_item = value; }

        private String _url_destino = String.Empty;
        public String url_destino { get => _url_destino; set => _url_destino = value; }

        private String _url_icono = String.Empty;
        public String url_icono { get => _url_icono; set => _url_icono = value; }

        private int _id_item_padre = 0;
        public int id_item_padre { get => _id_item_padre; set => _id_item_padre = value; }

        private int _id_modulo = 0;
        public int id_modulo { get => _id_modulo; set => _id_modulo = value; }

        private Boolean _activo = false;
        public Boolean activo { get => _activo; set => _activo = value; }

        private int _orden = 0;
        public int orden { get => _orden; set => _orden = value; }

        private String _version = String.Empty;
        public String version { get => _version; set => _version = value; }
    }
}
