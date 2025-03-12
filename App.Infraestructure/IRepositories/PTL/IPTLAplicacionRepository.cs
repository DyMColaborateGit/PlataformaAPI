using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLAplicacionRepository
    {
        Task<List<PTLAplicacionModels>> ListaAplicaciones();
    }
}
