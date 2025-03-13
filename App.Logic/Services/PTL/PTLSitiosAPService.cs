using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLSitiosAPService : IPTLSitiosAPService
    {
        private readonly IPTLSitiosAPRepository _PTLSitiosAPRepository;

        public PTLSitiosAPService(IPTLSitiosAPRepository PTLSitiosAPRepository)
        {
            _PTLSitiosAPRepository = PTLSitiosAPRepository;
        }

        public async Task<List<PTLSitiosAPModels>> ListaSitios()
        {
            return await _PTLSitiosAPRepository.ListaSitios();
        }
    }
}
