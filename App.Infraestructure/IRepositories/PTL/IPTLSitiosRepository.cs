using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLSitiosRepository
    {
        Task<List<PTLSitiosModels>> ListaSitios();

    }
}
