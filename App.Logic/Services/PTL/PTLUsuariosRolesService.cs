using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLUsuariosRolesService : IPTLUsuariosRolesService
    {
        private readonly IPTLUsuariosRolesRepository _PTLUsuariosRolesRepository;

        public PTLUsuariosRolesService(IPTLUsuariosRolesRepository PTLUsuariosRolesRepository)
        {
            _PTLUsuariosRolesRepository = PTLUsuariosRolesRepository;
        }

        public async Task<List<PTLUsuariosRolesModels>> ListaUsuariosRoles()
        {
            return await _PTLUsuariosRolesRepository.ListaUsuariosRoles();
        }
    }
}
