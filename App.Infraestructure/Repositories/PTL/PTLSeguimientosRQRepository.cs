using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLSeguimientosRQRepository : IPTLSeguimientosRQRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLSeguimientosRQRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLSeguimientosRQModels>> ListaSeguimientos()
        {
            try
            {
                var objResult = await _context.PTLSeguimientosRQ
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLSeguimientosRQModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaSeguimientos", ex, "");
                throw;
            }
        }
    }
}
