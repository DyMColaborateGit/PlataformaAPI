using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLSitiosAPService
    {
        Task<List<PTLSitiosAPModels>> ListaSitios();
        Task<PTLSitiosAPModels> GetSitioById(int SitioId);
        Task<PTLSitiosAPModels> PostInsertarSitios(PTLSitiosAPModels ObjInsertarSitio, string NombreSitio, string DescripcionSitio, string UrlSitio, bool EstadoSitio, int PuertoSitio);
    }
}
