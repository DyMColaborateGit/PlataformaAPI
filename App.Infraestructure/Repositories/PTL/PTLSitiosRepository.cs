using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLSitiosRepository : IPTLSitiosRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLSitiosRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLSitiosModels>> ListaSitios()
        {
            try
            {
                var objResult = await _context.PTLSitios.AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLSitiosModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaSitios", ex, "");
                throw;
            }
        }
    }
}
