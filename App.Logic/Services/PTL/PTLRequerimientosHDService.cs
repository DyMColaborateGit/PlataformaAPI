using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLRequerimientosHDService : IPTLRequerimientosHDService
    {
        private readonly IPTLRequerimientosHDRepository _PTLRequerimientosHDRepository;

        public PTLRequerimientosHDService(IPTLRequerimientosHDRepository PTLRequerimientosHDRepository)
        {
            _PTLRequerimientosHDRepository = PTLRequerimientosHDRepository;
        }

        public async Task<List<PTLRequerimientosHDModels>> ListaRequerimientos()
        {
            return await _PTLRequerimientosHDRepository.ListaRequerimientos();
        }
    }
}
