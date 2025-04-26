using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLSitiosAPRepository
    {
        Task<List<PTLSitiosAPModels>> GetListSitios();
        Task<PTLSitiosAPModels> GetSitioById(int SitioId);
        Task<PTLSitiosAPModels> PostInsertarSitios(PTLSitiosAPModels ObjInsertarSitio);
        Task<PTLSitiosAPModels> PutModificarSitio(PTLSitiosAPModels ObjModificarSitio);
        Task<PTLSitiosAPModels> DeleteSitio(int SitioId);
    }
}
