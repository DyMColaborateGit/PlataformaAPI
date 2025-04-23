using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLUsuariosSTRepository : IPTLUsuariosSTRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLUsuariosSTRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLUsuariosSTModels>> ListaUsuariosST()
        {
            try
            {
                var objResult = await _context.PTLUsuariosST
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLUsuariosSTModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaUsuariosST", ex, "");
                throw;
            }
        }
    }
}
