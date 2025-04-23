using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLPaquetesService
    {
        Task<List<PTLPaquetesModels>> ListaPaquetes();

    }
}
