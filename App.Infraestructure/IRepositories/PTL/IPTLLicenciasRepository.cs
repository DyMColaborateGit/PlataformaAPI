using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLLicenciasRepository
    {
        Task<List<PTLLicenciasModels>> ListaLicencias();

    }
}
