using App.Infraestructure.IRepositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLHelpDeskTicketsAPService : IPTLHelpDeskTicketsAPService
    {
        private readonly IPTLHelpDeskTicketsAPRepository _PTLHelpDeskTicketsAPRepository;

        public PTLHelpDeskTicketsAPService(IPTLHelpDeskTicketsAPRepository PTLHelpDeskTicketsAPRepository)
        {
            _PTLHelpDeskTicketsAPRepository = PTLHelpDeskTicketsAPRepository;
        }

        public async Task<List<PTLHelpDeskTicketsAPModels>> ListaTickets()
        {
            return await _PTLHelpDeskTicketsAPRepository.ListaTickets();
        }
    }
}
