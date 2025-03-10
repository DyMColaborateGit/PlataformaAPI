using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLRequerimientoHDService : IPTLRequerimientoHDService
    {
        private readonly IPTLRequerimientoHDRepository _PTLRequerimientoHDRepository;

        public PTLRequerimientoHDService(IPTLRequerimientoHDRepository PTLRequerimientoHDRepository)
        {
            _PTLRequerimientoHDRepository = PTLRequerimientoHDRepository;
        }

        public async Task<List<PTLRequerimientoHDModels>> ListaRequerimientos()
        {
            return await _PTLRequerimientoHDRepository.ListaRequerimientos();
        }
    }
}
