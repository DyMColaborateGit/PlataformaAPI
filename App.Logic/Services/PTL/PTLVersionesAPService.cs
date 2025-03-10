using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLVersionesAPService : IPTLVersionesAPService
    {
        private readonly IPTLVersionesAPRepository _PTLVersionesAPRepository;

        public PTLVersionesAPService(IPTLVersionesAPRepository PTLVersionesAPRepository)
        {
            _PTLVersionesAPRepository = PTLVersionesAPRepository;
        }

        public async Task<List<PTLVersionesAPModels>> ListaVersiones()
        {
            return await _PTLVersionesAPRepository.ListaVersiones();
        }
    }
}
