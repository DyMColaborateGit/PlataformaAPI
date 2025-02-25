using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLEnlasesSTRepository
    {
        Task<List<PTLEnlacesSTModels>> ListaEnlaces();

    }
}
