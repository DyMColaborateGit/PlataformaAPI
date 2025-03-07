using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLUsuariosRolesRepository : IPTLUsuariosRolesRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLUsuariosRolesRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLUsuariosRolesModels>> ListaUsuariosRoles()
        {
            try
            {
                var objResult = await _context.PTLUsuariosRoles
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLUsuariosRolesModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaUsuariosRoles", ex, "");
                throw;
            }
        }
    }
}
