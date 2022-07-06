using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.Api.Request
{
    public class ProfileUserRequestDTO
    {
        private string _UserName = string.Empty;
        //private string _NameApp = string.Empty;
        private int _keyCodeRol = 0;

        [Required]
        [StringLength(40, ErrorMessage = "No puede ingresar más de 40 caracteres")]
        public string UserName { get => _UserName; set => _UserName = value; }

        //[Required]
        //[StringLength(40, ErrorMessage = "No puede ingresar más de 40 caracteres")]
        //public string NameApp { get => _NameApp; set => _UserName = value; }
        [Range(0, int.MaxValue, ErrorMessage = "Se encontraron valores negativos en la clave de aplicación")]
        public int keyCodeRol { get => _keyCodeRol; set => _keyCodeRol = value; }
    }
}
