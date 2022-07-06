using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace GRC.Autenticacion.Entidades
{
    [Table("MODULO_APP")]
    public class Modulo_App: EtidadBase
    {
        private String _id_padre = String.Empty;
        public String id_padre { get => _id_padre; set => _id_padre = value; }

        private String _nombre_modulo = String.Empty;
        public String nombre_modulo { get => _nombre_modulo; set => _nombre_modulo = value; }

        private String _url_icono = String.Empty;
        public String url_icono { get => _url_icono; set => _url_icono = value; }

        private String _url_destino = String.Empty;
        public String url_destino { get => _url_destino; set => _url_destino = value; }

        private int _id_app = 0;
        public int id_app { get => _id_app; set => _id_app = value; }

        private Boolean _activo = false;
        public Boolean activo { get => _activo; set => _activo = value; }

        private String _version = String.Empty;
        public String version { get => _version; set => _version = value; }
    }
}
