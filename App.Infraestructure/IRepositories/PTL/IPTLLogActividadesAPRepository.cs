using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLLogActividadesAPRepository
    {
        Task<List<PTLLogActividadesAPModels>> ListaLogActividades();
    }
}
