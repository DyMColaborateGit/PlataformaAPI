using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLLogTransaccionesAPService : IPTLLogTransaccionesAPService
    {
        private readonly IPTLLogTransaccionesAPRepository _PTLLogTransaccionesAPRepository;

        public PTLLogTransaccionesAPService(IPTLLogTransaccionesAPRepository PTLLogTransaccionesAPRepository)
        {
            _PTLLogTransaccionesAPRepository = PTLLogTransaccionesAPRepository;
        }

        public async Task<List<PTLLogTransaccionesAPModels>> ListaLogTransacciones()
        {
            return await _PTLLogTransaccionesAPRepository.ListaLogTransacciones();
        }
    }
}
