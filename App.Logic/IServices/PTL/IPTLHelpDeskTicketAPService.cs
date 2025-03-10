using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLHelpDeskTicketAPService
    {
        Task<List<PTLHelpDeskTicketAPModels>> ListaTickets();
    }
}
