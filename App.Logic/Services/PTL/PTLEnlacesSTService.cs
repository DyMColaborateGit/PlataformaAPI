using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLEnlacesSTService : IPTLEnlacesSTService
    {
        private readonly IPTLEnlacesSTRepository _PTLEnlacesSTRepository;

        public PTLEnlacesSTService(IPTLEnlacesSTRepository PTLEnlacesSTRepository)
        {
            _PTLEnlacesSTRepository = PTLEnlacesSTRepository;
        }

        public async Task<List<PTLEnlacesSTModels>> ListaEnlaces()
        {
            return await _PTLEnlacesSTRepository.ListaEnlaces();
        }

        public async Task<PTLEnlacesSTModels> GetEnlaceById(int EnlaceId)
        {
            return await _PTLEnlacesSTRepository.GetEnlaceById(EnlaceId);
        }

        public async Task<PTLEnlacesSTModels> PostInsertarEnlace(PTLEnlacesSTModels ObjInsertarEnlace, string NombreEnlace, string DescripcionEnlace, string RutaEnlace, bool EstadoEnlace)
        {
            ObjInsertarEnlace.NombreEnlace = NombreEnlace;
            ObjInsertarEnlace.DescripcionEnlace = DescripcionEnlace;
            ObjInsertarEnlace.RutaEnlace = RutaEnlace;
            ObjInsertarEnlace.EstadoEnlace = EstadoEnlace;

            return await _PTLEnlacesSTRepository.PostInsertarEnlace(ObjInsertarEnlace);
        }
        public async Task<PTLEnlacesSTModels> PutModificarEnlace(PTLEnlacesSTModels ObjModificarEnlace, string NombreEnlace, string DescripcionEnlace, string RutaEnlace, bool EstadoEnlace)
        {
            ObjModificarEnlace.NombreEnlace = NombreEnlace;
            ObjModificarEnlace.DescripcionEnlace = DescripcionEnlace;
            ObjModificarEnlace.RutaEnlace = RutaEnlace;
            ObjModificarEnlace.EstadoEnlace = EstadoEnlace;

            return await _PTLEnlacesSTRepository.PutModificarEnlace(ObjModificarEnlace);
        }
        public async Task<PTLEnlacesSTModels> DeleteEnlace(int EnlaceId)
        {
            var ListResult = await _PTLEnlacesSTRepository.DeleteEnlace(EnlaceId);
            return ListResult;
        }
    }
}
