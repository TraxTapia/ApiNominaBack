using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Models.Nomina.Api.Response
{
    public class ObtenerListEmpleadosResponseDTO
    {
        public ObtenerListEmpleadosResponseDTO()
        {
            this.Result = new OperationResult.OperationResult();
        }
        public List<EmpleadosDTO> List { get; set; }
        public string Message { get; set; }
        public bool IsOk { get; set; }
        public OperationResult.OperationResult Result { get; set; }
    }
}

