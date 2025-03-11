using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLLogActualizacionesService : IPTLLogActualizacionesService
    {
        private readonly IPTLLogActualizacionesRepository _PTLLogActualizacionesRepository;

        public PTLLogActualizacionesService(IPTLLogActualizacionesRepository PTLLogActualizacionesRepository)
        {
            _PTLLogActualizacionesRepository = PTLLogActualizacionesRepository;
        }

        public async Task<List<PTLLogActualizacionesModels>> ListaLogActualizaciones()
        {
            return await _PTLLogActualizacionesRepository.ListaLogActualizaciones();
        }
    }
}
