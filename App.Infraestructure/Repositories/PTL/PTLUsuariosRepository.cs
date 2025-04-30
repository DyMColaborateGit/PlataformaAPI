using App.Infraestructure.Connect;
using App.Infraestructure.Connect.Entities.PTL;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLUsuariosRepository : IPTLUsuariosRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLUsuariosRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLUsuariosModels>> GetListUsuarios()
        {
            try
            {
                var objResult = await _context.PTLUsuarios
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLUsuariosModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("GetListUsuarios", ex, "");
                throw;
            }
        }

        public async Task<PTLUsuariosModels> GetUsuarioById(int UsuarioId)
        {
            try
            {
                var objResult = await _context.PTLUsuarios
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.UsuarioId == UsuarioId);
                return _mapper.Map<PTLUsuariosModels>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("GetUsuarioById", ex, UsuarioId.ToString());
                throw;
            }
        }

        public async Task<PTLUsuariosModels> PostInsertarUsuario(PTLUsuariosModels ObjInsertarUsuario)
        {
            PTLUsuariosEntities CreateRegistro = _mapper.Map<PTLUsuariosEntities>(ObjInsertarUsuario);
            try
            {
                _context.PTLUsuarios.Add(CreateRegistro);
                await _context.SaveChangesAsync();
                var ObjResult = await _context.PTLUsuarios.OrderByDescending(e => e.NombreUsuario).FirstOrDefaultAsync();
                return _mapper.Map<PTLUsuariosModels>(ObjInsertarUsuario);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PostInsertarUsuario", ex, JsonConvert.SerializeObject(ObjInsertarUsuario));
                throw;
            }
        }
        public async Task<PTLUsuariosModels> PutModificarUsuario(PTLUsuariosModels ObjUpdate)
        {
            var UpdateRegistro = _context.PTLUsuarios.FirstOrDefault(p => p.UsuarioId == ObjUpdate.UsuarioId);
            try
            {
                if (UpdateRegistro != null)
                {
                    #region Update
                    UpdateRegistro.FotoUsuario = ObjUpdate.FotoUsuario;
                    UpdateRegistro.IdentificacionUsuario = ObjUpdate.IdentificacionUsuario;
                    UpdateRegistro.NombreUsuario = ObjUpdate.NombreUsuario;
                    UpdateRegistro.DescripcionUsuario = ObjUpdate.DescripcionUsuario;
                    UpdateRegistro.CorreoUsuario = ObjUpdate.CorreoUsuario;
                    UpdateRegistro.ClaveUsuario = ObjUpdate.ClaveUsuario;
                    UpdateRegistro.EstadoUsuario = ObjUpdate.EstadoUsuario;
                    #endregion
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PutModificarUsuario", ex, JsonConvert.SerializeObject(ObjUpdate));
                throw;
            }
            return _mapper.Map<PTLUsuariosModels>(UpdateRegistro);
        }
        public async Task<PTLUsuariosModels> DeleteUsuario(int UsuarioId)
        {
            var objDelete = await _context.PTLUsuarios.FirstOrDefaultAsync(x => x.UsuarioId == UsuarioId);

            try
            {
                if (objDelete != null)
                {
                    _context.PTLUsuarios.Remove(objDelete);
                    await _context.SaveChangesAsync();
                }

                return _mapper.Map<PTLUsuariosModels>(objDelete);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("DeleteUsuario", ex, UsuarioId.ToString());
                throw;
            }
        }
    }
}
