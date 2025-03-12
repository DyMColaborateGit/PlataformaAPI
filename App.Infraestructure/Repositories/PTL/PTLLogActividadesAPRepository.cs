using App.Infraestructure.Connect;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLLogActividadesAPRepository : IPTLLogActividadesAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLLogActividadesAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLLogActividadesAPModels>> ListaLogActividades()
        {
            try
            {
                var objResult = await _context.PTLLogActividadesAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLLogActividadesAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaLogActividades", ex, "");
                throw;
            }
        }
    }
}
