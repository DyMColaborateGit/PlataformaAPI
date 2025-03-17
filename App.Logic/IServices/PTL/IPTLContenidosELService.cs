using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLContenidosELService
    {
        Task<List<PTLContenidosELModels>> ListaContenidos();
    }
}
