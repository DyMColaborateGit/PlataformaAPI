using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLUsuariosSTService
    {
        Task<List<PTLUsuariosSTModels>> ListaUsuariosST();
    }
}
