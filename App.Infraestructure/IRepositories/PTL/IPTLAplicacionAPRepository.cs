using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLAplicacionAPRepository
    {
        Task<List<PTLAplicacionAPModels>> ListaAplicaciones();
    }
}
