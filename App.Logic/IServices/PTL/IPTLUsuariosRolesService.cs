using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLUsuariosRolesService
    {
        Task<List<PTLUsuariosRolesModels>> ListaUsuariosRoles();
    }
}
