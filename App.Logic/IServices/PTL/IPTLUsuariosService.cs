using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLUsuariosService
    {
        Task<List<PTLUsuariosModels>> GetListUsuarios();
        Task<PTLUsuariosModels> GetUsuarioById(int UsuarioId);
        Task<PTLUsuariosModels> PostInsertarUsuario(PTLUsuariosModels ObjInsertarUsuario, string FotoUsuario, int IdentificacionUsuario, string NombreUsuario, string DescripcionUsuario, string CorreoUsuario, string ClaveUsuario, bool EstadoSitio);
        Task<PTLUsuariosModels> PutModificarUsuario(PTLUsuariosModels ObjModificarUsuario, string FotoUsuarioint, int IdentificacionUsuario, string NombreUsuario, string DescripcionUsuario, string CorreoUsuario, string ClaveUsuario, bool EstadoSitio);
        Task<PTLUsuariosModels> DeleteUsuario(int UsuarioId);
    }
}
