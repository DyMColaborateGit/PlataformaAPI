using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLLogTransaccionesAPService
    {
        Task<List<PTLLogTransaccionesAPModels>> ListaLogTransacciones();

    }
}
