using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLEnlacesSTRepository
    {
        Task<List<PTLEnlacesSTModels>> GetListEnlaces();
        Task<PTLEnlacesSTModels> GetEnlaceById(int EnlaceId);
        Task<PTLEnlacesSTModels> PostInsertarEnlace(PTLEnlacesSTModels ObjInsertarEnlace);
        Task<PTLEnlacesSTModels> PutModificarEnlace(PTLEnlacesSTModels ObjModificarEnlace);
        Task<PTLEnlacesSTModels> DeleteEnlace(int EnlaceId);
    }
}
