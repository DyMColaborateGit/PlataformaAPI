using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLLicenciasService : IPTLLicenciasService
    {
        private readonly IPTLLicenciasRepository _PTLLicenciasRepository;

        public PTLLicenciasService(IPTLLicenciasRepository PTLLicenciasRepository)
        {
            _PTLLicenciasRepository = PTLLicenciasRepository;
        }

        public async Task<List<PTLLicenciasModels>> ListaLicencias()
        {
            return await _PTLLicenciasRepository.ListaLicencias();
        }
    }
}
