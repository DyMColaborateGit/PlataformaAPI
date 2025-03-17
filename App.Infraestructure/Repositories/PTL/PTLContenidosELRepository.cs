using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLContenidosELRepository : IPTLContenidosELRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLContenidosELRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLContenidosELModels>> ListaContenidos()
        {
            try
            {
                var objResult = await _context.PTLContenidosEL
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLContenidosELModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaContenidos", ex, "");
                throw;
            }
        }
    }
}
