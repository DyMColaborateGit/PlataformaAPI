using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLLogActividadesAPService
    {
        Task<List<PTLLogActividadesAPModels>> ListaLogActividades();
    }
}
