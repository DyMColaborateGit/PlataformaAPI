using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLContentsELService
    {
        Task<List<PTLContentsELModels>> ListaContenidos();
    }
}
