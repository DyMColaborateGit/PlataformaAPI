using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLEmpresasSTService : IPTLEmpresasSTService
    {
        private readonly IPTLEmpresasSTRepository _PTLEmpresasSTRepository;

        public PTLEmpresasSTService(IPTLEmpresasSTRepository PTLEmpresasSTRepository)
        {
            _PTLEmpresasSTRepository = PTLEmpresasSTRepository;
        }

        public async Task<List<PTLEmpresasSTModels>> ListaEmpresas()
        {
            return await _PTLEmpresasSTRepository.ListaEmpresas();
        }
    }
}
