using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLLicenciasSTRepository
    {
        Task<List<PTLLicenciasSTModels>> ListaLicencias();

    }
}
