using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Models.Nomina.Api.Response
{
    public class SelctGeneralResponseDTO
    {
        public SelctGeneralResponseDTO()
        {
            this.Result = new OperationResult.OperationResult();
        }
        public List<SelectGeneralDTO> List { get; set; }
        public string Message { get; set; }
        public bool IsOk { get; set; }
        public OperationResult.OperationResult Result { get; set; }
    }
}
