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
        [HttpPost]
        [Route("Api/SelectPrestaciones")]
        public async Task<SelctGeneralResponseDTO> SelectPrestaciones()
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
                _Response = await apiCore.GetCatPrestaciones();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCveContables")]
        public async Task<SelctGeneralResponseDTO> SelectCveContables()
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
                _Response = await apiCore.GetCveContables();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCatHorarios")]
        public async Task<SelctGeneralResponseDTO> SelectCatHorarios()
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
                _Response = await apiCore.GetCatHorarios();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectBancos")]
        public async Task<SelctGeneralResponseDTO> GetCatBancos()
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
                _Response = await apiCore.GetCatBancos();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCodReservado1")]
        public async Task<SelctGeneralResponseDTO> GetCodReservado1()
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
                _Response = await apiCore.GetCodReservado1();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCodReservado2")]
        public async Task<SelctGeneralResponseDTO> GetCodReservado2()
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
                _Response = await apiCore.GetCodReservado2();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectGetCodReservado3")]
        public async Task<SelctGeneralResponseDTO> GetCodReservado3()
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
                _Response = await apiCore.GetCodReservado3();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCodReservado4")]
        public async Task<SelctGeneralResponseDTO> GetCodReservado4()
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
                _Response = await apiCore.GetCodReservado4();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectGetCodReservado5")]
        public async Task<SelctGeneralResponseDTO> GetCodReservado5()
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
                _Response = await apiCore.GetCodReservado5();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectGetCodReservado6")]
        public async Task<SelctGeneralResponseDTO> GetCodReservado6()
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
                _Response = await apiCore.GetCodReservado6();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectGetCodReservado7")]
        public async Task<SelctGeneralResponseDTO> GetCodReservado7()
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
                _Response = await apiCore.GetCodReservado7();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectGetCodReservado8")]
        public async Task<SelctGeneralResponseDTO> GetCodReservado8()
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
                _Response = await apiCore.GetCodReservado8();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectTipoContratos")]
        public async Task<SelctGeneralResponseDTO> GetTipoContratos()
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
                _Response = await apiCore.GetTipoContratos();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectDirecciones")]
        public async Task<SelctGeneralResponseDTO> GetCatDirecciones()
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
                _Response = await apiCore.GetCatDirecciones();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectSubdirecciones")]
        public async Task<SelctGeneralResponseDTO> GetCatSubdirecciones()
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
                _Response = await apiCore.GetCatSubdirecciones();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectDepartamentos")]
        public async Task<SelctGeneralResponseDTO> GetCatDepartamentos()
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
                _Response = await apiCore.GetCatDepartamentos();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectPuestos")]
        public async Task<SelctGeneralResponseDTO> GetCatPuestos()
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
                _Response = await apiCore.GetCatPuestos();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCatetgoriaSueldos")]
        public async Task<SelctGeneralResponseDTO> GetCatetgoriaSueldos()
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
                _Response = await apiCore.GetCatetgoriaSueldos();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectTurnos")]
        public async Task<SelctGeneralResponseDTO> GetTurnos()
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
                _Response = await apiCore.GetTurnos();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCveRegistroPatronal")]
        public async Task<SelctGeneralResponseDTO> GetCveRegistroPatronal()
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
                _Response = await apiCore.GetCveRegistroPatronal();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectCentroBeneficios")]
        public async Task<SelctGeneralResponseDTO> GetCentroBeneficios()
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
                _Response = await apiCore.GetCentroBeneficios();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }
        [HttpPost]
        [Route("Api/SelectTipoNomina")]
        public async Task<SelctGeneralResponseDTO> GetTipoNomina()
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
                _Response = await apiCore.GetTipoNomina();
            }
            catch (Exception ex)
            {
                _Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.Result.AddException(ex);
            }
            return _Response;
        }

        [HttpPost]
        [Route("Api/DeleteEmployer")]
        public async  Task<OperationResult> DeleteEmployer(DeleteEmployeRequestDTO _Request)
        {
            OperationResult _Response = new OperationResult();
            try
            {
                if (!ModelState.IsValid)
                {
                    var _Errors = ModelState.Values.SelectMany(x => x.Errors).ToList();
                    _Response.SetStatusCode(OperationResult.StatusCodesEnum.BAD_REQUEST);
                    _Errors.ForEach(x => { if (x.Exception == null) _Response.AddException(new Exception(x.ErrorMessage)); else _Response.AddException(x.Exception); });
                    return _Response;
                }
                _Response = await apiCore.DeleteEmployerByCode(_Request.CodeEmployer,_Request.CodeStatus);
            }
            catch (Exception ex)
            {
                //this._Logger.LogError(ex);
                _Response.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.AddException(ex);
            }
            return _Response;
        }
    }

}
