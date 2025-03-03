using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLEnlasesSTRepository : IPTLEnlasesSTRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLEnlasesSTRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLEnlacesSTModels>> ListaEnlaces()
        {
            try
            {
                var objResult = await _context.PTLEnlacesST.AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLEnlacesSTModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaEnlaces", ex, "");
                throw;
            }
        }
    }
}
