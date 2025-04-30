using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLEnlacesSTService
    {
        Task<List<PTLEnlacesSTModels>> GetListEnlaces();
        Task<PTLEnlacesSTModels> GetEnlaceById(int EnlaceId);
        Task<PTLEnlacesSTModels> PostInsertarEnlace(PTLEnlacesSTModels ObjInsertarEnlace, string NombreEnlace, string DescripcionEnlace, string RutaEnlace, bool EstadoEnlace);
        Task<PTLEnlacesSTModels> PutModificarEnlace(PTLEnlacesSTModels ObjModificarEnlace, string NombreEnlace, string DescripcionEnlace, string RutaEnlace, bool EstadoEnlace);
        Task<PTLEnlacesSTModels> DeleteEnlace(int EnlaceId);
    }
}
