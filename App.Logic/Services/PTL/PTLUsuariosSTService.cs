using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLUsuariosSTService : IPTLUsuariosSTService
    {
        private readonly IPTLUsuariosSTRepository _PTLUsuariosSTRepository;

        public PTLUsuariosSTService(IPTLUsuariosSTRepository PTLUsuariosSTRepository)
        {
            _PTLUsuariosSTRepository = PTLUsuariosSTRepository;
        }

        public async Task<List<PTLUsuariosSTModels>> ListaUsuariosST()
        {
            return await _PTLUsuariosSTRepository.ListaUsuariosST();
        }
    }
}
