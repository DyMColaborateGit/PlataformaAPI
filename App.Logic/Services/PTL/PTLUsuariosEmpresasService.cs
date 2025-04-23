using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLUsuariosEmpresasService : IPTLUsuariosEmpresasService
    {
        private readonly IPTLUsuariosEmpresasRepository _PTLUsuariosEmpresasRepository;

        public PTLUsuariosEmpresasService(IPTLUsuariosEmpresasRepository PTLUsuariosEmpresasRepository)
        {
            _PTLUsuariosEmpresasRepository = PTLUsuariosEmpresasRepository;
        }

        public async Task<List<PTLUsuariosEmpresasModels>> ListaUsuariosEmpresa()
        {
            return await _PTLUsuariosEmpresasRepository.ListaUsuariosEmpresa();
        }
    }
}
