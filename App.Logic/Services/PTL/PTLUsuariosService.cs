using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLUsuariosService : IPTLUsuariosService
    {
        private readonly IPTLUsuariosRepository _PTLUsuariosRepository;

        public PTLUsuariosService(IPTLUsuariosRepository PTLUsuariosRepository)
        {
            _PTLUsuariosRepository = PTLUsuariosRepository;
        }

        public async Task<List<PTLUsuariosModels>> ListaUsuarios()
        {
            return await _PTLUsuariosRepository.ListaUsuarios();
        }
    }
}
