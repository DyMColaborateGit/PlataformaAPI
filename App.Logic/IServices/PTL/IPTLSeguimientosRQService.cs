using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLSeguimientosRQService
    {
        Task<List<PTLSeguimientosRQModels>> ListaSeguimientos();
    }
}
