using Api.Models.Nomina.Api;
using Api.Models.Nomina.Api.Request;
using Api.Models.Nomina.Api.Response;
using Api.Models.Nomina.OperationResult;
using Api.Models.Nomina.Settings;
using Api.Negocio.Nomina.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Seguridad.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        ApiCore apiCore = null;
        public EmpleadosController(IOptions<AppSettings> _appSettings)
        {
            apiCore = new ApiCore(_appSettings);
        }
        [HttpPost]
        [Route("Api/Empleados")]
        public async Task<ObtenerListEmpleadosResponseDTO> ObtenerEmpleados()
        {
            ObtenerListEmpleadosResponseDTO _Response = new ObtenerListEmpleadosResponseDTO();
            try
            {
                if (!ModelState.IsValid)
                {
                    var _Errors = ModelState.Values.SelectMany(x => x.Errors).ToList();
                    _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.BAD_REQUEST);
                    _Errors.ForEach(x => { if (x.Exception == null) _Response.Result.AddException(new Exception(x.ErrorMessage)); else _Response.Result.AddException(x.Exception); });
                }
                _Response = await apiCore.ObtenerEmpleados();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCompanias")]
        public async Task<GetListCompaniasResponseDTO> ObtenerCompanias()
        {
            GetListCompaniasResponseDTO _Response = new GetListCompaniasResponseDTO();
            try
            {
                if (!ModelState.IsValid)
                {
                    var _Errors = ModelState.Values.SelectMany(x => x.Errors).ToList();
                    _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.BAD_REQUEST);
                    _Errors.ForEach(x => { if (x.Exception == null) _Response.Result.AddException(new Exception(x.ErrorMessage)); else _Response.Result.AddException(x.Exception); });
                }
                _Response = await apiCore.GetListCompanias();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectLocalidades")]
        public async Task<GetListLocalidadesResponseDTO> ObtenerLocalidades()
        {
            GetListLocalidadesResponseDTO _Response = new GetListLocalidadesResponseDTO();
            try
            {
                if (!ModelState.IsValid)
                {
                    var _Errors = ModelState.Values.SelectMany(x => x.Errors).ToList();
                    _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.BAD_REQUEST);
                    _Errors.ForEach(x => { if (x.Exception == null) _Response.Result.AddException(new Exception(x.ErrorMessage)); else _Response.Result.AddException(x.Exception); });
                }
                _Response = await apiCore.GetListLocalidades();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCategorias")]
        public async Task<SelctGeneralResponseDTO> SelectCategorias()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            try
            {
                if (!ModelState.IsValid)
                {
                    var _Errors = ModelState.Values.SelectMany(x => x.Errors).ToList();
                    _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.BAD_REQUEST);
                    _Errors.ForEach(x => { if (x.Exception == null) _Response.Result.AddException(new Exception(x.ErrorMessage)); else _Response.Result.AddException(x.Exception); });
                }
                _Response = await apiCore.GetCatCategoria();
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
