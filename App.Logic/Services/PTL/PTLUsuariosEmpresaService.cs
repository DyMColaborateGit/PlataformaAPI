using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLUsuariosEmpresaService : IPTLUsuariosEmpresaService
    {
        private readonly IPTLUsuariosEmpresaRepository _PTLUsuariosEmpresaRepository;

        public PTLUsuariosEmpresaService(IPTLUsuariosEmpresaRepository PTLUsuariosEmpresaRepository)
        {
            _PTLUsuariosEmpresaRepository = PTLUsuariosEmpresaRepository;
        }

        public async Task<List<PTLUsuariosEmpresaModels>> ListaUsuariosEmpresa()
        {
            return await _PTLUsuariosEmpresaRepository.ListaUsuariosEmpresa();
        }
    }
}
