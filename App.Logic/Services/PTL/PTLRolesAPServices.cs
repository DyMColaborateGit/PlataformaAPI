using App.Infraestructure.IRepositories.PTL;
using App.Infraestructure.Repositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.logic.Services.PTL
{
    public class PTLRolesAPServices : IPTLRolesAPServices
    {
        private readonly IPTLRolesAPRespository _PTLRolesAPRespository;

        public PTLRolesAPServices(IPTLRolesAPRespository PTLRolesAPRespository)
        {
            _PTLRolesAPRespository = PTLRolesAPRespository;
        }

        public async Task<List<PTLRolesAPModels>> GetListRoles()
        {
            return await _PTLRolesAPRespository.GetListRoles();
        }
        public async Task<PTLRolesAPModels> GetRolesById(int RolId)
        {
            return await _PTLRolesAPRespository.GetRolesById(RolId);
        }

        public async Task<PTLRolesAPModels> PostInsertarRoles(PTLRolesAPModels ObjInsertarRoles, string NombreRol, string DescripcionRol, bool EstadoRol)
        {
            ObjInsertarRoles.NombreRol = NombreRol;
            ObjInsertarRoles.DescripcionRol = DescripcionRol;
            ObjInsertarRoles.EstadoRol = EstadoRol;

            return await _PTLRolesAPRespository.PostInsertarRoles(ObjInsertarRoles);
        }
        public async Task<PTLRolesAPModels> PutModificarRoles(PTLRolesAPModels ObjModificarRoles, string NombreRol, string DescripcionRol, bool EstadoRol)
        {
            ObjModificarRoles.NombreRol = NombreRol;
            ObjModificarRoles.DescripcionRol = DescripcionRol;
            ObjModificarRoles.EstadoRol = EstadoRol;

            return await _PTLRolesAPRespository.PutModificarRoles(ObjModificarRoles);
        }
        public async Task<PTLRolesAPModels> DeleteRoles(int RolId)
        {
            var ListResult = await _PTLRolesAPRespository.DeleteRoles(RolId);
            return ListResult;
        }
    }
}
