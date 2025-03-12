using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLAplicacionService : IPTLAplicacionService
    {
        private readonly IPTLAplicacionRepository _PTLAplicacionRepository;

        public PTLAplicacionService(IPTLAplicacionRepository PTLAplicacionRepository)
        {
            _PTLAplicacionRepository = PTLAplicacionRepository;
        }

        public async Task<List<PTLAplicacionModels>> ListaAplicaciones()
        {
            return await _PTLAplicacionRepository.ListaAplicaciones();
        }
    }
}
