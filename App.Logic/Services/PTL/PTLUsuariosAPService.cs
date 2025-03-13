using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLUsuariosAPService : IPTLUsuariosAPService
    {
        private readonly IPTLUsuariosAPRepository _PTLUsuariosAPRepository;

        public PTLUsuariosAPService(IPTLUsuariosAPRepository PTLUsuariosAPRepository)
        {
            _PTLUsuariosAPRepository = PTLUsuariosAPRepository;
        }

        public async Task<List<PTLUsuariosAPModels>> ListaUsuarios()
        {
            return await _PTLUsuariosAPRepository.ListaUsuarios();
        }
    }
}
