using App.Infraestructure.IRepositories.PTL;
using App.Infraestructure.Repositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLUsuariosService : IPTLUsuariosService
    {
        private readonly IPTLUsuariosRepository _PTLUsuariosRepository;

        public PTLUsuariosService(IPTLUsuariosRepository PTLUsuariosRepository)
        {
            _PTLUsuariosRepository = PTLUsuariosRepository;
        }

        public async Task<List<PTLUsuariosModels>> GetListUsuarios()
        {
            return await _PTLUsuariosRepository.GetListUsuarios();
        }

        public async Task<PTLUsuariosModels> GetUsuarioById(int UsuarioId)
        {
            return await _PTLUsuariosRepository.GetUsuarioById(UsuarioId);
        }

        public async Task<PTLUsuariosModels> PostInsertarUsuario(PTLUsuariosModels ObjInsertarUsuario, string FotoUsuario, string NombreUsuario, string DescripcionUsuario, string CorreoUsuario, string ClaveUsuario, bool EstadoSitio)
        {
            ObjInsertarUsuario.FotoUsuario = FotoUsuario;
            ObjInsertarUsuario.NombreUsuario = NombreUsuario;
            ObjInsertarUsuario.DescripcionUsuario = DescripcionUsuario;
            ObjInsertarUsuario.CorreoUsuario = CorreoUsuario;
            ObjInsertarUsuario.ClaveUsuario = ClaveUsuario;
            ObjInsertarUsuario.EstadoUsuario = EstadoSitio;

            return await _PTLUsuariosRepository.PostInsertarUsuario(ObjInsertarUsuario);
        }
        public async Task<PTLUsuariosModels> PutModificarUsuario(PTLUsuariosModels ObjModificarUsuario, string FotoUsuario, string NombreUsuario, string DescripcionUsuario, string CorreoUsuario, string ClaveUsuario, bool EstadoSitio)
        {
            ObjModificarUsuario.FotoUsuario = FotoUsuario;
            ObjModificarUsuario.NombreUsuario = NombreUsuario;
            ObjModificarUsuario.DescripcionUsuario = DescripcionUsuario;
            ObjModificarUsuario.CorreoUsuario = CorreoUsuario;
            ObjModificarUsuario.ClaveUsuario = ClaveUsuario;
            ObjModificarUsuario.EstadoUsuario = EstadoSitio;

            return await _PTLUsuariosRepository.PutModificarUsuario(ObjModificarUsuario);
        }
        public async Task<PTLUsuariosModels> DeleteUsuario(int UsuarioId)
        {
            var ListResult = await _PTLUsuariosRepository.DeleteUsuario(UsuarioId);
            return ListResult;
        }
    }
}
