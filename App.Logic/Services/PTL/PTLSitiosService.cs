using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLSitiosService : IPTLSitiosService
    {
        private readonly IPTLSitiosRepository _PTLSitiosRepository;

        public PTLSitiosService(IPTLSitiosRepository PTLSitiosRepository)
        {
            _PTLSitiosRepository = PTLSitiosRepository;
        }

        public async Task<List<PTLSitiosModels>> ListaSitios()
        {
            return await _PTLSitiosRepository.ListaSitios();
        }
    }
}
