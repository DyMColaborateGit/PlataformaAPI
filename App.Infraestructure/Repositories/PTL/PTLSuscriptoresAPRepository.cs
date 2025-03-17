using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLSuscriptoresAPRepository : IPTLSuscriptoresAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLSuscriptoresAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLSuscriptoresAPModels>> ListaSuscriptores()
        {
            try
            {
                var objResult = await _context.PTLSuscriptoresAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLSuscriptoresAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaSuscriptores", ex, "");
                throw;
            }
        }
    }
}
