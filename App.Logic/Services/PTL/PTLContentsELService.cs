using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLContentsELService : IPTLContentsELService
    {
        private readonly IPTLContentsELRepository _PTLContenidosELRepository;

        public PTLContentsELService(IPTLContentsELRepository PTLContenidosELRepository)
        {
            _PTLContenidosELRepository = PTLContenidosELRepository;
        }

        public async Task<List<PTLContentsELModels>> ListaContenidos()
        {
            return await _PTLContenidosELRepository.ListaContenidos();
        }
    }
}
