using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLUsuariosAPRepository : IPTLUsuariosAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLUsuariosAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLUsuariosAPModels>> ListaUsuarios()
        {
            try
            {
                var objResult = await _context.PTLUsuariosAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLUsuariosAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaUsuarios", ex, "");
                throw;
            }
        }
    }
}
