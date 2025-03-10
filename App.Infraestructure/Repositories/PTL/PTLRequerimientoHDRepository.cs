using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLRequerimientoHDRepository : IPTLRequerimientoHDRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLRequerimientoHDRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLRequerimientoHDModels>> ListaRequerimientos()
        {
            try
            {
                var objResult = await _context.PTLRequerimientoHD
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLRequerimientoHDModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaRequerimientos", ex, "");
                throw;
            }
        }
    }
}
