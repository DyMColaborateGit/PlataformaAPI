using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLAplicacionAPRepository : IPTLAplicacionAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLAplicacionAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLAplicacionAPModels>> ListaAplicaciones()
        {
            try
            {
                var objResult = await _context.PTLAplicacionesAP.AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLAplicacionAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaAplicaciones", ex, "");
                throw;
            }
        }
    }
}
