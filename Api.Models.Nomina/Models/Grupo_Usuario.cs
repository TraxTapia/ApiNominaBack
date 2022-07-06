using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace GRC.Autenticacion.Entidades
{
    [Table("GRUPO_USUARIO")]
    public class Grupo_Usuario : EtidadBase 
    {
        private int _id_grupo = 0;
        public int id_grupo { get => _id_grupo; set => _id_grupo = value; }

        private int _id_usuario = 0;
        public int id_usuario { get => _id_usuario; set => _id_usuario = value; }

        private Boolean _otorgar = false;
        public Boolean otorgar { get => _otorgar; set => _otorgar = value; }

        private Boolean _denegar = false;
        public Boolean denegar { get => _denegar; set => _denegar = value; }

    }
}
