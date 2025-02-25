using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLEnlacesSTService : IPTLEnlacesSTService
    {
        private readonly IPTLEnlasesSTRepository _PTLEnlasesSTRepository;

        public PTLEnlacesSTService(IPTLEnlasesSTRepository PTLEnlasesSTRepository)
        {
            _PTLEnlasesSTRepository = PTLEnlasesSTRepository;
        }

        public async Task<List<PTLEnlacesSTModels>> ListaEnlaces()
        {
            return await _PTLEnlasesSTRepository.ListaEnlaces();
        }
    }
}
