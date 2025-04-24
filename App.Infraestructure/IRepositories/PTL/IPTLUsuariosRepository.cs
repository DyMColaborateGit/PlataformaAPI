using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLUsuariosRepository
    {
        Task<List<PTLUsuariosModels>> GetListUsuarios();
        Task<PTLUsuariosModels> GetUsuarioById(int UsuarioId);
        Task<PTLUsuariosModels> PostInsertarUsuario(PTLUsuariosModels ObjInsertarUsuario);
        Task<PTLUsuariosModels> PutModificarUsuario(PTLUsuariosModels ObjModificarUsuario);
        Task<PTLUsuariosModels> DeleteUsuario(int UsuarioId);
    }
}
