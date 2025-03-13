using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLSitiosAPService
    {
        Task<List<PTLSitiosAPModels>> ListaSitios();
    }
}
