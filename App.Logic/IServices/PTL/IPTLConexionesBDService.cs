using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLConexionesBDService
    {
        Task<List<PTLConexionesBDModels>> ListaConexiones();
    }
}
