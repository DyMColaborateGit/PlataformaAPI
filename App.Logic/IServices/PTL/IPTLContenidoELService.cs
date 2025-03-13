using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLContenidoELService
    {
        Task<List<PTLContenidoELModels>> ListaContenidos();
    }
}
