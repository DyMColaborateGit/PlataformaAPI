using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLContentsELRepository
    {
        Task<List<PTLContentsELModels>> ListaContenidos();
    }
}
