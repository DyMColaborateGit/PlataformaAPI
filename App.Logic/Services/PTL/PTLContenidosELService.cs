using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLContenidosELService : IPTLContenidosELService
    {
        private readonly IPTLContenidosELRepository _PTLContenidosELRepository;

        public PTLContenidosELService(IPTLContenidosELRepository PTLContenidosELRepository)
        {
            _PTLContenidosELRepository = PTLContenidosELRepository;
        }

        public async Task<List<PTLContenidosELModels>> ListaContenidos()
        {
            return await _PTLContenidosELRepository.ListaContenidos();
        }
    }
}
