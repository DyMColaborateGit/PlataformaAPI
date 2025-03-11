using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLSeguimientoRQRepository
    {
        Task<List<PTLSeguimientoRQModels>> ListaSeguimientos();
    }
}
