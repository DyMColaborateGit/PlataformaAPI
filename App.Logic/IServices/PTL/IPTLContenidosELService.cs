using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLContenidosELService
    {
        Task<List<PTLContenidosELModels>> ListaContenidos();
        Task<PTLContenidosELModels> GetContenidoById(int ContenidoId);
        Task<PTLContenidosELModels> PostInsertarContenido(PTLContenidosELModels ObjInsertarContenido, string NombreContenido, string DescripcionContenido, string Contenido, bool EstadoContenido);
        Task<PTLContenidosELModels> PutModificarContenido(PTLContenidosELModels ObjModificarContenido, string NombreContenido, string DescripcionContenido, string Contenido, bool EstadoContenido);
        Task<PTLContenidosELModels> DeleteContenido(int ContenidoId);
    }
}
