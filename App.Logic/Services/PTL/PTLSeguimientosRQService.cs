using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLSeguimientosRQService : IPTLSeguimientosRQService
    {
        private readonly IPTLSeguimientosRQRepository _PTLSeguimientosRQRepository;

        public PTLSeguimientosRQService(IPTLSeguimientosRQRepository PTLSeguimientosRQRepository)
        {
            _PTLSeguimientosRQRepository = PTLSeguimientosRQRepository;
        }

        public async Task<List<PTLSeguimientosRQModels>> ListaSeguimientos()
        {
            return await _PTLSeguimientosRQRepository.ListaSeguimientos();
        }
    }
}
