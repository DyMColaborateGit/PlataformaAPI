using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLSeguimientoRQRepository : IPTLSeguimientoRQRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLSeguimientoRQRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLSeguimientoRQModels>> ListaSeguimientos()
        {
            try
            {
                var objResult = await _context.PTLSeguimientoRQ
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLSeguimientoRQModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaSeguimientos", ex, "");
                throw;
            }
        }
    }
}
