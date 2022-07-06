using Api.Models.Nomina.Api;
using Api.Models.Nomina.Api.Request;
using Api.Models.Nomina.DBContexNomina;
using Api.Models.Nomina.OperationResult;
using Api.Models.Nomina.Settings;
using Api.Negocio.Nomina.RepositoryApi;
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
       
    }
}
