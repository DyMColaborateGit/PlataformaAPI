using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLModulosAPRepository : IPTLModulosAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLModulosAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLModulosAPModels>> ListaModulos()
        {
            try
            {
                var objResult = await _context.PTLModuloAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLModulosAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaModulos", ex, "");
                throw;
            }
        }
    }
}
