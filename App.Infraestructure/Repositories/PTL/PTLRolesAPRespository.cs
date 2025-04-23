using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLRolesAPRespository : IPTLRolesAPRespository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLRolesAPRespository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLRolesAPModels>> ListaRoles()
        {
            try
            {
                var objResult = await _context.PTLRolesAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLRolesAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaRoles", ex, "");
                throw;
            }
        }
    }
}
