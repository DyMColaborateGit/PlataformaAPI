using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLHelpDeskTicketsAPRepository
    {
        Task<List<PTLHelpDeskTicketsAPModels>> ListaTickets();

    }
}
