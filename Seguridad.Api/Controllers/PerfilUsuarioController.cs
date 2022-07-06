using Api.Models.Nomina.Api;
using Api.Models.Nomina.Api.Request;
using Api.Models.Nomina.OperationResult;
using Api.Models.Nomina.Settings;
using Api.Negocio.Nomina.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguridad.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PerfilUsuarioController : ControllerBase
    {
        ApiCore apiCore = null;
        public PerfilUsuarioController(IOptions<AppSettings> _appSettings)
        {
            apiCore = new ApiCore(_appSettings);
        }
        [HttpPost]
       [Route("Api/userProfile")]
       public GetListProfileUserResponseDTO ObtenerPerfilUsuario(ProfileUserRequestDTO _Request)
        {
            GetListProfileUserResponseDTO _Response = new GetListProfileUserResponseDTO();
       
            try
            {
                if (!ModelState.IsValid)
                {
                    var _Errors = ModelState.Values.SelectMany(x => x.Errors).ToList();
                    _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.BAD_REQUEST);
                    _Errors.ForEach(x => { if (x.Exception == null) _Response.Result.AddException(new Exception(x.ErrorMessage)); else _Response.Result.AddException(x.Exception); });
                }
              
                _Response = apiCore.GetPerfilsUsers(_Request.UserName, _Request.keyCodeRol);

            }
            catch (Exception ex) 
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;


        }
    }
}
