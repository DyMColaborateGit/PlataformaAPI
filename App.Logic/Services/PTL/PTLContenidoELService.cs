using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLContenidoELService : IPTLContenidoELService
    {
        private readonly IPTLContenidoELRepository _PTLContenidoELRepository;

        public PTLContenidoELService(IPTLContenidoELRepository PTLContenidoELRepository)
        {
            _PTLContenidoELRepository = PTLContenidoELRepository;
        }

        public async Task<List<PTLContenidoELModels>> ListaContenidos()
        {
            return await _PTLContenidoELRepository.ListaContenidos();
        }
    }
}
