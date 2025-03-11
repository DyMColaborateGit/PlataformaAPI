using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLPaquetesRepository : IPTLPaquetesRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLPaquetesRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLPaquetesModels>> ListaPaquetes()
        {
            try
            {
                var objResult = await _context.PTLPaquetes
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLPaquetesModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaPaquetes", ex, "");
                throw;
            }
        }
    }
}
