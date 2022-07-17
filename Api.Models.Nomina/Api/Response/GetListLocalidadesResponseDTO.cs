using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Models.Nomina.Api.Response
{
    public class GetListLocalidadesResponseDTO
    {

        public GetListLocalidadesResponseDTO()
        {
            this.Result = new OperationResult.OperationResult();
        }
        public List<CompaniaDTO> List { get; set; }
        public string Message { get; set; }
        public bool IsOk { get; set; }
        public OperationResult.OperationResult Result { get; set; }
    }
}

