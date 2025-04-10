using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLRequerimientosHDService
    {
        Task<List<PTLRequerimientosHDModels>> ListaRequerimientos();
    }
}
