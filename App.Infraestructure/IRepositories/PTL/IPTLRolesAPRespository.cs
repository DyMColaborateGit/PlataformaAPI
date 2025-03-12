using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLRolesAPRespository
    {
        Task<List<PTLRolesAPModels>> ListaRoles();
    }
}
