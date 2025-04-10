using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLSuscriptoresAPService : IPTLSuscriptoresAPService
    {
        private readonly IPTLSuscriptoresAPRepository _PTLSuscriptoresAPRepository;

        public PTLSuscriptoresAPService(IPTLSuscriptoresAPRepository PTLSuscriptoresAPRepository)
        {
            _PTLSuscriptoresAPRepository = PTLSuscriptoresAPRepository;
        }

        public async Task<List<PTLSuscriptoresAPModels>> ListaSuscriptores()
        {
            return await _PTLSuscriptoresAPRepository.ListaSuscriptores();
        }
    }
}
