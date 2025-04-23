using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLLicenciasService
    {
        Task<List<PTLLicenciasModels>> ListaLicencias();
    }
}
