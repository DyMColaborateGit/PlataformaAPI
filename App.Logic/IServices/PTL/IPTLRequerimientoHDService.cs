using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLRequerimientoHDService
    {
        Task<List<PTLRequerimientoHDModels>> ListaRequerimientos();
    }
}
