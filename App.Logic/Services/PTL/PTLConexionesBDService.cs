using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLConexionesBDService : IPTLConexionesBDService
    {
        private readonly IPTLConexionesBDRepository _PTLConexionesBDRepository;

        public PTLConexionesBDService(IPTLConexionesBDRepository PTLConexionesBDRepository)
        {
            _PTLConexionesBDRepository = PTLConexionesBDRepository;
        }

        public async Task<List<PTLConexionesBDModels>> ListaConexiones()
        {
            return await _PTLConexionesBDRepository.ListaConexiones();
        }
    }
}
