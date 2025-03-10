using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLModulosAPRepository
    {
        Task<List<PTLModulosAPModels>> ListaModulos();
    }
}
