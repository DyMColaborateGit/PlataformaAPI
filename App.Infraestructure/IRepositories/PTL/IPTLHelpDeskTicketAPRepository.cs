using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLHelpDeskTicketAPRepository
    {
        Task<List<PTLHelpDeskTicketAPModels>> ListaTickets();

    }
}
