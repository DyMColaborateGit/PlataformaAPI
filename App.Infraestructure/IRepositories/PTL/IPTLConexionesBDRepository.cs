using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLConexionesBDRepository
    {
        Task<List<PTLConexionesBDModels>> ListaConexiones();

    }
}
