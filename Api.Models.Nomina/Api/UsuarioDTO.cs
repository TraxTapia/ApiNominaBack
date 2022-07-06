using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Models.Nomina.Api
{
    public  class UsuarioDTO
    {
        public int Id { get; set; }
        public int IdApp { get; set; }
        public string NombreApp { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public int IdGrupo { get; set; }
        public string NombreGrupo  { get; set; }
        public string Usuario { get; set; }
        public int IdEstatusUsuario { get; set; }
        public string EstatusUsuario { get; set;}
        public int IdPersona { get; set; }
        public int IdModulo { get; set; }
        public string NombreModulo{ get; set; }
        public int IdOpcionModulo{ get; set; }
        public string NombreItem{ get; set; }



    }
}
