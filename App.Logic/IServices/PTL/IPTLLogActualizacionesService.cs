using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLLogActualizacionesService
    {
        Task<List<PTLLogActualizacionesModels>> ListaLogActualizaciones();

    }
}
