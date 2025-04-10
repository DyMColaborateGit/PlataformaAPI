using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLAplicacionesService
    {
        Task<List<PTLAplicacionesModels>> ListaAplicaciones();
    }
}
