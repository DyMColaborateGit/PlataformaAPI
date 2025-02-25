using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLSitiosService
    {
        Task<List<PTLSitiosModels>> ListaSitios();
    }
}
