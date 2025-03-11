using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLLicenciasSTService
    {
        Task<List<PTLLicenciasSTModels>> ListaLicencias();
    }
}
