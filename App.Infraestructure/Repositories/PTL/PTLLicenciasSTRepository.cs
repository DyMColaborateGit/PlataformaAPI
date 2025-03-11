using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLLicenciasSTRepository : IPTLLicenciasSTRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLLicenciasSTRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLLicenciasSTModels>> ListaLicencias()
        {
            try
            {
                var objResult = await _context.PTLLicenciasST
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLLicenciasSTModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaLicencias", ex, "");
                throw;
            }
        }
    }
}
