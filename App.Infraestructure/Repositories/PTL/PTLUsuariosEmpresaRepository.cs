using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLUsuariosEmpresaRepository : IPTLUsuariosEmpresaRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLUsuariosEmpresaRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLUsuariosEmpresaModels>> ListaUsuariosEmpresa()
        {
            try
            {
                var objResult = await _context.PTLUsuariosEmpresa
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLUsuariosEmpresaModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaUsuariosEmpresa", ex, "");
                throw;
            }
        }
    }
}
