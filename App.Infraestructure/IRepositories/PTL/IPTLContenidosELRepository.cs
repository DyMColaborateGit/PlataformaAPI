using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLContenidosELRepository
    {
        Task<List<PTLContenidosELModels>> ListaContenidos();
        Task<PTLContenidosELModels> GetContenidoById(int ContenidoId);
        Task<PTLContenidosELModels> PostInsertarContenido(PTLContenidosELModels ObjInsertarContenido);
        Task<PTLContenidosELModels> PutModificarContenido(PTLContenidosELModels ObjModificarContenido);
        Task<PTLContenidosELModels> DeleteContenido(int ContenidoId);
    }
}
