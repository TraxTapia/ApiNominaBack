using Api.Models.Nomina.Api;
using Api.Models.Nomina.Api.Request;
using Api.Models.Nomina.Api.Response;
using Api.Models.Nomina.DBContexNomina;
using Api.Models.Nomina.Enum;
using Api.Models.Nomina.OperationResult;
using Api.Models.Nomina.Settings;
using Api.Negocio.Nomina.RepositoryApi;
using Bsase_Datos_Model.Nomina;
using GRC.Autenticacion.Entidades;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Negocio.Nomina.Core
{
    public class ApiCore
    {
        private readonly IOptions<AppSettings> appSettings;
        private string _cadenaConexion = string.Empty;
        public ApiCore()
        {

        }
        public ApiCore(IOptions<AppSettings> _appSettings)
        {
            appSettings = _appSettings;

        }
        public ApiCore(string connectionString)
        {
            _cadenaConexion = connectionString;
        }

        public GetListProfileUserResponseDTO GetPerfilsUsers(string _UserName, int _KeyCodeApp)
        {
            GetListProfileUserResponseDTO _Response = new GetListProfileUserResponseDTO();
            Repository _Repo = new Repository(appSettings);
            _Response.List = _Repo.GetRolesByUser(_UserName, _KeyCodeApp);
            if (!_Response.List.Any()) throw new Exception("No se econtraron resultados");

            return _Response;
        }
        public async Task<ObtenerListEmpleadosResponseDTO> ObtenerEmpleados()
        {
            ObtenerListEmpleadosResponseDTO _Response = new ObtenerListEmpleadosResponseDTO();
            Repository _Repo = new Repository(appSettings);
            var _Query = await _Repo.GetEmpleados();
            if (_Query == null) throw new Exception("No se econtraron resultados");

            _Response.List = _Query.Select(x => new EmpleadosDTO()
            {
                Code = x.Code,
                Name = x.Name,

            }).ToList();

            return _Response;
        }
        public async Task<GetListCompaniasResponseDTO> GetListCompanias()
        {
            GetListCompaniasResponseDTO _Response = new GetListCompaniasResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetListCompanias();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new CompaniaDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<GetListLocalidadesResponseDTO> GetListLocalidades()
        {
            GetListLocalidadesResponseDTO _Response = new GetListLocalidadesResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetListLocalidades();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new CompaniaDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCatCategoria()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCatalogoCategoria();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCatPrestaciones()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCatPrestaciones();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCveContables()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCveContables();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCatHorarios()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCatHorarios();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCatBancos()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCatBancos();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCodReservado1()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCodReservado1();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCodReservado2()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCodReservado2();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCodReservado3()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCodReservado3();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCodReservado4()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCodReservado4();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCodReservado5()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCodReservado5();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCodReservado6()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCodReservado6();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCodReservado7()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCodReservado7();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCodReservado8()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCodReservado8();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetTipoContratos()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetTipoContratos();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCatDirecciones()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCatDirecciones();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCatSubdirecciones()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCatSubdirecciones();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCatDepartamentos()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCatDepartamentos();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCatPuestos()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCatPuestos();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCatetgoriaSueldos()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCatetgoriaSueldos();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetTurnos()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetTurnos();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCveRegistroPatronal()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCveRegistroPatronal();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetCentroBeneficios()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetCentroBeneficios();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }
        public async Task<SelctGeneralResponseDTO> GetTipoNomina()
        {
            SelctGeneralResponseDTO _Response = new SelctGeneralResponseDTO();
            Repository repository = new Repository(appSettings);
            var _Data = await repository.GetTipoNomina();
            if (_Data == null) throw new Exception("No se econtraron resultados");
            _Response.List = _Data.Select(x => new SelectGeneralDTO()
            {
                Code = x.Code,
                Name = x.Name,
            }).ToList();
            return _Response;
        }


        public async Task<OperationResult> DeleteEmployerByCode(string _Code, string _Status)
        {
            OperationResult _Response = new OperationResult();
            C_AST_011 _UpdateData = new C_AST_011();
            Repository repository = new Repository(appSettings);
            _UpdateData = await repository.FindUserByCode(_Code);
            if (_UpdateData == null) throw new Exception("No se encontro el empleado a eliminar");
            _UpdateData.U_STAT = "B";
            repository.Actualizar(_UpdateData);
            return _Response;
        }

    }

}
