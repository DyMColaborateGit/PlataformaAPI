using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLUsuariosRepository
    {
        Task<List<PTLUsuariosModels>> ListaUsuarios();

    }
}
