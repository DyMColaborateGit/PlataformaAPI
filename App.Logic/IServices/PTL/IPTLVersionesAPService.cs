using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLVersionesAPService
    {
        Task<List<PTLVersionesAPModels>> ListaVersiones();
    }
}
