using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLAplicacionesService : IPTLAplicacionesService
    {
        private readonly IPTLAplicacionesRepository _PTLAplicacionesRepository;

        public PTLAplicacionesService(IPTLAplicacionesRepository PTLAplicacionesRepository)
        {
            _PTLAplicacionesRepository = PTLAplicacionesRepository;
        }

        public async Task<List<PTLAplicacionesModels>> ListaAplicaciones()
        {
            return await _PTLAplicacionesRepository.ListaAplicaciones();
        }
    }
}
