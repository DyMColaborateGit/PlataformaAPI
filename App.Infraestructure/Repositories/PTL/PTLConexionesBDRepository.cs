using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLConexionesBDRepository : IPTLConexionesBDRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLConexionesBDRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLConexionesBDModels>> ListaConexiones()
        {
            try
            {
                var objResult = await _context.PTLConexionesBD
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLConexionesBDModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaConexiones", ex, "");
                throw;
            }
        }
    }
}
