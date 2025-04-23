using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLRequerimientosHDRepository
    {
        Task<List<PTLRequerimientosHDModels>> ListaRequerimientos();

    }
}
