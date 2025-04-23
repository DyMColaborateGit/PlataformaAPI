using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLHelpDeskTicketsAPRepository : IPTLHelpDeskTicketsAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLHelpDeskTicketsAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLHelpDeskTicketsAPModels>> ListaTickets()
        {
            try
            {
                var objResult = await _context.PTLHelpDeskTicketsAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLHelpDeskTicketsAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaTickets", ex, "");
                throw;
            }
        }
    }
}
