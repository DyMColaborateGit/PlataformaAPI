using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLRolesAPRespository
    {
        Task<List<PTLRolesAPModels>> GetListRoles();
        Task<PTLRolesAPModels> GetRolesById(int RolId);
        Task<PTLRolesAPModels> PostInsertarRoles(PTLRolesAPModels ObjInsertarRoles);
        Task<PTLRolesAPModels> PutModificarRoles(PTLRolesAPModels ObjModificarRoles);
        Task<PTLRolesAPModels> DeleteRoles(int RolId);
    }
}
