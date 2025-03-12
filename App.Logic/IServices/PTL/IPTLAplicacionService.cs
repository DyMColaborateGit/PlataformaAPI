using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLAplicacionService
    {
        Task<List<PTLAplicacionModels>> ListaAplicaciones();
    }
}
