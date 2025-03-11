using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLUsuariosEmpresaRepository
    {
        Task<List<PTLUsuariosEmpresaModels>> ListaUsuariosEmpresa();

    }
}
