using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLAplicacionesRepository
    {
        Task<List<PTLAplicacionesModels>> ListaAplicaciones();
    }
}
