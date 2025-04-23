using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLLogTransaccionesAPRepository
    {
        Task<List<PTLLogTransaccionesAPModels>> ListaLogTransacciones();

    }
}
