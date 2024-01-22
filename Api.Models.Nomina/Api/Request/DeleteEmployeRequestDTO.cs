using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.Models.Nomina.Api.Request
{
    public class DeleteEmployeRequestDTO
    {
        [Required]
        [StringLength(16,ErrorMessage ="No puede ingresar más de 16 caracteres")]
        public string CodeEmployer { get; set; }
        [Required]
        [StringLength(1, ErrorMessage = "No puede ingresar más de 1 caracter")]
        public string CodeStatus { get; set; } 
    }
}
