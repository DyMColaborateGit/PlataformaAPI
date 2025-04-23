using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLPaquetesRepository
    {
        Task<List<PTLPaquetesModels>> ListaPaquetes();

    }
}
