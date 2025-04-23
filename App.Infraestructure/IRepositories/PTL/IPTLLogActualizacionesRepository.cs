
using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLLogActualizacionesRepository
    {
        Task<List<PTLLogActualizacionesModels>> ListaLogActualizaciones();
    }
}
