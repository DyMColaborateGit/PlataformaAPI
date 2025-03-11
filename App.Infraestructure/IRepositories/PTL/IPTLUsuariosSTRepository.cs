using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLUsuariosSTRepository
    {
        Task<List<PTLUsuariosSTModels>> ListaUsuariosST();

    }
}
