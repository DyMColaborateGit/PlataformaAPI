using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLSuscriptorAPRepository : IPTLSuscriptorAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLSuscriptorAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLSuscriptorAPModels>> ListaSuscriptores()
        {
            try
            {
                var objResult = await _context.PTLSuscriptorAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLSuscriptorAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaSuscriptores", ex, "");
                throw;
            }
        }
    }
}
