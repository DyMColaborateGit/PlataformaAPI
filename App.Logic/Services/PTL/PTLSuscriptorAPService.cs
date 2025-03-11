using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLSuscriptorAPService : IPTLSuscriptorAPService
    {
        private readonly IPTLSuscriptorAPRepository _PTLSuscriptorAPRepository;

        public PTLSuscriptorAPService(IPTLSuscriptorAPRepository PTLSuscriptorAPRepository)
        {
            _PTLSuscriptorAPRepository = PTLSuscriptorAPRepository;
        }

        public async Task<List<PTLSuscriptorAPModels>> ListaSuscriptores()
        {
            return await _PTLSuscriptorAPRepository.ListaSuscriptores();
        }
    }
}
