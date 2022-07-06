using Api.Models.Nomina.Api;
using Api.Models.Nomina.DBContexNomina;
using Api.Models.Nomina.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Negocio.Nomina.RepositoryApi
{
    public class Repository
    {
        private readonly IOptions<AppSettings> appSettings;

        private string _cadenaConexion = string.Empty;
        public Repository(IOptions<AppSettings> _appSettings)
        {

            appSettings = _appSettings;

        }
        public Repository(string connectionString)
        {
            _cadenaConexion = connectionString;
        }

        public async Task<List<CAT_APP>> GetCatAppUser(int _IdApp)
        {
            List<CAT_APP> _lista = new List<CAT_APP>();
            using (DBContexNomina _context = new DBContexNomina(appSettings.Value.ConnectionStrings["ConnNomina"]))
            {
                _lista = await _context.CAT_APP
                    .Include(x => x.CAT_ROL)
                    .Include(x => x.MODULO_APP)
                    .Include(x => x.MENSAJE_APP)
                    .Include(x => x.URL_POST_APP)
                    .Where(x => x.Id.Equals(_IdApp)).ToListAsync();
            }
            return _lista;
        }
        public async Task<List<USUARIO>> GetUser(string _Usuario)
        {
            List<USUARIO> _lista = new List<USUARIO>();
            using (DBContexNomina _context = new DBContexNomina(appSettings.Value.ConnectionStrings["ConnNomina"]))
            {
                _lista = await _context.USUARIO
                .Include(x => x.CAT_ESTATUS_USR)
                .Include(x => x.GRUPO_USUARIO).Where(x => x.usuario1 == _Usuario).ToListAsync();
            }
            return _lista;
        }

        public async Task<List<CAT_ROL>> GetRoles(int _Rol)
        {
            List<CAT_ROL> _lista = new List<CAT_ROL>();
            using (DBContexNomina _context = new DBContexNomina(appSettings.Value.ConnectionStrings["ConnNomina"]))
            {
                _lista = await _context.CAT_ROL.Where(x => x.Id == _Rol).ToListAsync();
            }
            return _lista;
        }


        public List<UsuarioDTO> GetRolesByUser(string _UserName, int _IdAplicacion)
        {
            List<UsuarioDTO> _List = new List<UsuarioDTO>();
            using (DBContexNomina _Context = new DBContexNomina(appSettings.Value.ConnectionStrings["ConnNomina"]))
            {
                if (_IdAplicacion != 0)
                {
                    var _List1 = (from app in _Context.CAT_APP
                                  join catRol in _Context.CAT_ROL on app.Id equals catRol.id_app
                                  join gRol in _Context.GRUPO_ROL on catRol.Id equals gRol.id_rol
                                  join g in _Context.GRUPO on gRol.id_grupo equals g.Id
                                  join gUser in _Context.GRUPO_USUARIO on g.Id equals gUser.id_grupo
                                  join user in _Context.USUARIO on gUser.id_usuario equals user.Id
                                  join estatus in _Context.CAT_ESTATUS_USR on user.id_estatus_usr equals estatus.Id
                                  join mapp in _Context.MODULO_APP on app.Id equals mapp.id_app
                                  join om in _Context.OPCION_MODULO on mapp.id_padre equals om.id_modulo
                                  where user.usuario1 == _UserName && app.Id == _IdAplicacion
                                  select new UsuarioDTO()
                                  {
                                      Id = user.Id,
                                      IdApp = app.Id,
                                      IdGrupo = g.Id,
                                      IdRol = catRol.Id,
                                      NombreApp = app.nombre_app,
                                      Usuario = user.usuario1,
                                      EstatusUsuario = estatus.estatus,
                                      NombreRol = catRol.descripcion,
                                      NombreGrupo = g.grupo1,
                                      IdEstatusUsuario = estatus.Id,
                                      IdPersona = user.id_persona,
                                      IdModulo = mapp.Id,
                                      NombreModulo = mapp.nombre_modulo,
                                      IdOpcionModulo = om.Id,
                                      NombreItem = om.descripcion_item
                                  }).ToList();
                    return _List = _List1.ToList();

                }
                else
                {
                    var _List1 = (from app in _Context.CAT_APP
                                  join catRol in _Context.CAT_ROL on app.Id equals catRol.id_app
                                  join gRol in _Context.GRUPO_ROL on catRol.Id equals gRol.id_rol
                                  join g in _Context.GRUPO on gRol.id_grupo equals g.Id
                                  join gUser in _Context.GRUPO_USUARIO on g.Id equals gUser.id_grupo
                                  join user in _Context.USUARIO on gUser.id_usuario equals user.Id
                                  join estatus in _Context.CAT_ESTATUS_USR on user.id_estatus_usr equals estatus.Id
                                  join mapp in _Context.MODULO_APP on app.Id equals mapp.id_app
                                  join om in _Context.OPCION_MODULO on mapp.id_padre equals om.id_modulo
                                  where user.usuario1 == _UserName 
                                  select new UsuarioDTO()
                                  {
                                      Id = user.Id,
                                      IdApp = app.Id,
                                      IdGrupo = g.Id,
                                      IdRol = catRol.Id,
                                      NombreApp = app.nombre_app,
                                      Usuario = user.usuario1,
                                      EstatusUsuario = estatus.estatus,
                                      NombreRol = catRol.descripcion,
                                      NombreGrupo = g.grupo1,
                                      IdEstatusUsuario = estatus.Id,
                                      IdPersona = user.id_persona,
                                      IdModulo = mapp.Id,
                                      NombreModulo = mapp.nombre_modulo,
                                      IdOpcionModulo = om.Id,
                                      NombreItem = om.descripcion_item

                                  }).ToList();
                    return _List = _List1.ToList();
                }


            }


        }

    }
}
