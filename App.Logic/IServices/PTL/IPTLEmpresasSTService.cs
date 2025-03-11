using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLEmpresasSTService
    {
        Task<List<PTLEmpresasSTModels>> ListaEmpresas();

    }
}
