using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLAplicacionAPService
    {
        Task<List<PTLAplicacionAPModels>> ListaAplicaciones();
    }
}
