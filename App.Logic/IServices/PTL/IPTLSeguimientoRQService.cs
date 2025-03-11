using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLSeguimientoRQService
    {
        Task<List<PTLSeguimientoRQModels>> ListaSeguimientos();
    }
}
