using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLContenidosELRepository
    {
        Task<List<PTLContenidosELModels>> ListaContenidos();
    }
}
