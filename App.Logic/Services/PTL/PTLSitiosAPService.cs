using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLSitiosAPService : IPTLSitiosAPService
    {
        private readonly IPTLSitiosAPRepository _PTLSitiosAPRepository;

        public PTLSitiosAPService(IPTLSitiosAPRepository PTLSitiosAPRepository)
        {
            _PTLSitiosAPRepository = PTLSitiosAPRepository;
        }

        public async Task<List<PTLSitiosAPModels>> GetListSitios()
        {
            return await _PTLSitiosAPRepository.GetListSitios();
        }
        public async Task<PTLSitiosAPModels> GetSitioById(int SitioId)
        {
            return await _PTLSitiosAPRepository.GetSitioById(SitioId);
        }

        public async Task<PTLSitiosAPModels> PostInsertarSitios(PTLSitiosAPModels ObjInsertarSitio, string NombreSitio, string DescripcionSitio, string UrlSitio, bool EstadoSitio, int PuertoSitio)
        {
            ObjInsertarSitio.NombreSitio = NombreSitio;
            ObjInsertarSitio.DescripcionSitio = DescripcionSitio;
            ObjInsertarSitio.UrlSitio = UrlSitio;
            ObjInsertarSitio.EstadoSitio = EstadoSitio;
            ObjInsertarSitio.PuertoSitio = PuertoSitio;

            return await _PTLSitiosAPRepository.PostInsertarSitios(ObjInsertarSitio);
        }
        public async Task<PTLSitiosAPModels> PutModificarSitio(PTLSitiosAPModels ObjModificarSitio, string NombreSitio, string DescripcionSitio, string UrlSitio, bool EstadoSitio, int PuertoSitio)
        {
            ObjModificarSitio.NombreSitio = NombreSitio;
            ObjModificarSitio.DescripcionSitio = DescripcionSitio;
            ObjModificarSitio.UrlSitio = UrlSitio;
            ObjModificarSitio.EstadoSitio = EstadoSitio;
            ObjModificarSitio.PuertoSitio = PuertoSitio;

            return await _PTLSitiosAPRepository.PutModificarSitio(ObjModificarSitio);
        }
        public async Task<PTLSitiosAPModels> DeleteSitio(int SitioId)
        {
            var ListResult = await _PTLSitiosAPRepository.DeleteSitio(SitioId);
            return ListResult;
        }

    }
}
