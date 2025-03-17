using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLUsuariosEmpresasRepository : IPTLUsuariosEmpresasRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLUsuariosEmpresasRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLUsuariosEmpresasModels>> ListaUsuariosEmpresa()
        {
            try
            {
                var objResult = await _context.PTLUsuariosEmpresas
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLUsuariosEmpresasModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaUsuariosEmpresa", ex, "");
                throw;
            }
        }
    }
}
