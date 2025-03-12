using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLLicenciasRepository : IPTLLicenciasRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLLicenciasRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLLicenciasModels>> ListaLicencias()
        {
            try
            {
                var objResult = await _context.PTLLicencias
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLLicenciasModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaLicencias", ex, "");
                throw;
            }
        }
    }
}
