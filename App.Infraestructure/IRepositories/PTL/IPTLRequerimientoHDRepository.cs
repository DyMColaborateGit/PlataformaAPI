using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLRequerimientoHDRepository
    {
        Task<List<PTLRequerimientoHDModels>> ListaRequerimientos();

    }
}
