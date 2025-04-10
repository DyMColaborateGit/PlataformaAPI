using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLUsuariosEmpresasRepository
    {
        Task<List<PTLUsuariosEmpresasModels>> ListaUsuariosEmpresa();

    }
}
