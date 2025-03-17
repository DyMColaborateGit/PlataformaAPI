using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLSuscriptoresAPService
    {
        Task<List<PTLSuscriptoresAPModels>> ListaSuscriptores();

    }
}
