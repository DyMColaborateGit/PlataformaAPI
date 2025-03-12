using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLLogActividadesAPService : IPTLLogActividadesAPService
    {
        private readonly IPTLLogActividadesAPRepository _PTLLogActividadesAPRepository;

        public PTLLogActividadesAPService(IPTLLogActividadesAPRepository PTLLogActividadesAPRepository)
        {
            _PTLLogActividadesAPRepository = PTLLogActividadesAPRepository;
        }

        public async Task<List<PTLLogActividadesAPModels>> ListaLogActividades()
        {
            return await _PTLLogActividadesAPRepository.ListaLogActividades();
        }
    }
}
