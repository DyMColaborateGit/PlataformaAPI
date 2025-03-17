using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLHelpDeskTicketsAPService
    {
        Task<List<PTLHelpDeskTicketsAPModels>> ListaTickets();
    }
}
