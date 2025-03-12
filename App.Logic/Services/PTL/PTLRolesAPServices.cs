using App.Infraestructure.IRepositories.PTL;
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

        public async Task<List<PTLRolesAPModels>> ListaRoles()
        {
            return await _PTLRolesAPRespository.ListaRoles();
        }
    }
}
