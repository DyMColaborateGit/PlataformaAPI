using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLRequerimientosHDRepository : IPTLRequerimientosHDRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLRequerimientosHDRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLRequerimientosHDModels>> ListaRequerimientos()
        {
            try
            {
                var objResult = await _context.PTLRequerimientosHD
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLRequerimientosHDModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaRequerimientos", ex, "");
                throw;
            }
        }
    }
}
