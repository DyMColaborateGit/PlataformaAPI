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
    public class PTLRolesServices : IPTLRolesServices
    {
        private readonly IPTLRolesRespository _PTLRolesRespository;

        public PTLRolesServices(IPTLRolesRespository PTLRolesRespository)
        {
            _PTLRolesRespository = PTLRolesRespository;
        }

        public async Task<List<PTLRolesModels>> ListaRoles()
        {
            return await _PTLRolesRespository.ListaRoles();
        }
    }
}
