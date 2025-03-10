using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLHelpDeskTicketAPService : IPTLHelpDeskTicketAPService
    {
        private readonly IPTLHelpDeskTicketAPRepository _PTLHelpDeskTicketAPRepository;

        public PTLHelpDeskTicketAPService(IPTLHelpDeskTicketAPRepository PTLHelpDeskTicketAPRepository)
        {
            _PTLHelpDeskTicketAPRepository = PTLHelpDeskTicketAPRepository;
        }

        public async Task<List<PTLHelpDeskTicketAPModels>> ListaTickets()
        {
            return await _PTLHelpDeskTicketAPRepository.ListaTickets();
        }
    }
}
