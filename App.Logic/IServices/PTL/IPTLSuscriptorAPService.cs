using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLSuscriptorAPService
    {
        Task<List<PTLSuscriptorAPModels>> ListaSuscriptores();

    }
}
