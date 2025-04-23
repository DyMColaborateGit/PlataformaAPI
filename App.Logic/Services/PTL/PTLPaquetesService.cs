using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLPaquetesService : IPTLPaquetesService
    {
        private readonly IPTLPaquetesRepository _PTLPaquetesRepository;

        public PTLPaquetesService(IPTLPaquetesRepository PTLPaquetesRepository)
        {
            _PTLPaquetesRepository = PTLPaquetesRepository;
        }

        public async Task<List<PTLPaquetesModels>> ListaPaquetes()
        {
            return await _PTLPaquetesRepository.ListaPaquetes();
        }
    }
}
