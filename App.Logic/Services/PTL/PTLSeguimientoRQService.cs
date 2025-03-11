using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLSeguimientoRQService : IPTLSeguimientoRQService
    {
        private readonly IPTLSeguimientoRQRepository _PTLSeguimientoRQRepository;

        public PTLSeguimientoRQService(IPTLSeguimientoRQRepository PTLSeguimientoRQRepository)
        {
            _PTLSeguimientoRQRepository = PTLSeguimientoRQRepository;
        }

        public async Task<List<PTLSeguimientoRQModels>> ListaSeguimientos()
        {
            return await _PTLSeguimientoRQRepository.ListaSeguimientos();
        }
    }
}
