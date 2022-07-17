using Api.Models.Nomina.Api;
using Api.Models.Nomina.Api.Response;
using Api.Models.Nomina.DBContexNomina;
using Api.Models.Nomina.NominaDBCtxt;
using Api.Models.Nomina.Settings;
using Bsase_Datos_Model.Nomina;
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

        public async Task<List<C_AST_011>> GetEmpleados()
        {
            List<C_AST_011> _List = new List<C_AST_011>();
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                _List = await _Context.C_AST_011.AsNoTracking().Where(x => x.U_STAT == "A").ToListAsync();

            }
            return _List;
        }
        public async Task<List<C_AST_001>> GetListCompanias()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_001.AsNoTracking().ToListAsync();
            }

        }
        public async Task<List<C_AST_701>> GetListLocalidades()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_701.AsNoTracking().ToListAsync();
            }

        }
        public async Task<List<C_AST_704>> GetCatalogoCategoria()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_704.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_132>> GetCatPrestaciones()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_132.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_709>> GetCveContables()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_709.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_737>> GetCatHorarios()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_737.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_708>> GetCatBancos()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_708.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_711>> GetCodReservado1()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_711.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_712>> GetCodReservado2()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_712.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_713>> GetCodReservado3()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_713.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_714>> GetCodReservado4()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_714.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_715>> GetCodReservado5()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_715.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_716>> GetCodReservado6()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_716.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_717>> GetCodReservado7()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_717.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_718>> GetCodReservado8()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_718.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_705>> GetTipoContratos()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_705.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_722>> GetCatDirecciones()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_722.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_747>> GetCatSubdirecciones()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_747.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_723>> GetCatDepartamentos()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_723.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_702>> GetCatPuestos()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_702.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_754>> GetCatetgoriaSueldos()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_754.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_706>> GetTurnos()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_706.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_142>> GetCveRegistroPatronal()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_142.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_F11>> GetCentroBeneficios()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_F11.AsNoTracking().ToListAsync();

            }
        }
        public async Task<List<C_AST_703>> GetTipoNomina()
        {
            using (DBContextNominaCTX _Context = new DBContextNominaCTX(appSettings.Value.ConnectionStrings["Nomina"]))
            {
                return await _Context.C_AST_703.AsNoTracking().ToListAsync();

            }
        }
    }
}
