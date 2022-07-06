using Api.Models.Nomina.DBContexNomina;
using GRC.Autenticacion.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Models.Nomina.Api
{
    public  class GetListProfileUserResponseDTO
    {
        public GetListProfileUserResponseDTO()
        {
            this.Result = new OperationResult.OperationResult();
        }
        public List<UsuarioDTO> List { get; set; }
        public string Message { get; set; }
        public bool IsOk { get; set; }
        public OperationResult.OperationResult Result { get; set; }
    }
}
