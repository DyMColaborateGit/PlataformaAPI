using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLAplicacionRepository : IPTLAplicacionRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLAplicacionRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLAplicacionModels>> ListaAplicaciones()
        {
            try
            {
                var objResult = await _context.PTLAplicacion
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLAplicacionModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaAplicaciones", ex, "");
                throw;
            }
        }
    }
}
