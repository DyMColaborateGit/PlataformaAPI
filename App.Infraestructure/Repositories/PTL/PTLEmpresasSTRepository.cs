using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLEmpresasSTRepository : IPTLEmpresasSTRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLEmpresasSTRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLEmpresasSTModels>> ListaEmpresas()
        {
            try
            {
                var objResult = await _context.PTLEmpresasST
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLEmpresasSTModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaEmpresas", ex, "");
                throw;
            }
        }
    }
}
