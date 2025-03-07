using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLUsuariosRepository : IPTLUsuariosRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLUsuariosRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLUsuariosModels>> ListaUsuarios()
        {
            try
            {
                var objResult = await _context.PTLUsuarios
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLUsuariosModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaUsuarios", ex, "");
                throw;
            }
        }
    }
}
