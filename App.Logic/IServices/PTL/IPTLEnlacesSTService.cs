using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLEnlacesSTService
    {
        Task<List<PTLEnlacesSTModels>> ListaEnlaces();
    }
}
