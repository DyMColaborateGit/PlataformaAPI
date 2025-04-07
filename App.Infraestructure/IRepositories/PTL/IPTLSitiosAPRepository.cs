using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLSitiosAPRepository
    {
        Task<List<PTLSitiosAPModels>> ListaSitios();
        Task<PTLSitiosAPModels> GetSitioById(int SitioId);
        Task<PTLSitiosAPModels> PostInsertarSitios(PTLSitiosAPModels ObjInsertarSitio);
    }
}
