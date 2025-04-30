using App.Models.Models.PTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.logic.IServices.PTL
{
    public interface IPTLRolesAPServices
    {
        Task<List<PTLRolesAPModels>> GetListRoles();
        Task<PTLRolesAPModels> GetRolesById(int RolId);
        Task<PTLRolesAPModels> PostInsertarRoles(PTLRolesAPModels ObjInsertarRoles, string NombreRol, string DescripcionRol, bool EstadoRol);
        Task<PTLRolesAPModels> PutModificarRoles(PTLRolesAPModels ObjModificarRoles, string NombreRol, string DescripcionRol, bool EstadoRol);
        Task<PTLRolesAPModels> DeleteRoles(int RolId);
    }
}
