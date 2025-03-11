using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLLicenciasSTService : IPTLLicenciasSTService
    {
        private readonly IPTLLicenciasSTRepository _PTLLicenciasSTRepository;

        public PTLLicenciasSTService(IPTLLicenciasSTRepository PTLLicenciasSTRepository)
        {
            _PTLLicenciasSTRepository = PTLLicenciasSTRepository;
        }

        public async Task<List<PTLLicenciasSTModels>> ListaLicencias()
        {
            return await _PTLLicenciasSTRepository.ListaLicencias();
        }
    }
}
