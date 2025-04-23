using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLSeguimientosRQRepository
    {
        Task<List<PTLSeguimientosRQModels>> ListaSeguimientos();
    }
}
