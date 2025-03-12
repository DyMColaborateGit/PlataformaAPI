using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLLogTransaccionesAPRepository : IPTLLogTransaccionesAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLLogTransaccionesAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLLogTransaccionesAPModels>> ListaLogTransacciones()
        {
            try
            {
                var objResult = await _context.PTLLogTransaccionesAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLLogTransaccionesAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaLogTransacciones", ex, "");
                throw;
            }
        }
    }
}
