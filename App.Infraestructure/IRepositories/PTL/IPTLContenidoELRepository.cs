using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLContenidoELRepository
    {
        Task<List<PTLContenidoELModels>> ListaContenidos();
    }
}
