using App.Infraestructure.Connect;
using App.Infraestructure.Connect.Entities.PTL;
using App.Infraestructure.Helpers;
using App.Infraestructure.IRepositories.PTL;
using App.Models.Models.PTL;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace App.Infraestructure.Repositories.PTL
{
    public class PTLSitiosAPRepository : IPTLSitiosAPRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLSitiosAPRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLSitiosAPModels>> ListaSitios()
        {
            try
            {
                var objResult = await _context.PTLSitiosAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLSitiosAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("ListaSitios", ex, "");
                throw;
            }
        }
        public async Task<PTLSitiosAPModels> GetSitioById(int SitioId)
        {
            try
            {
                var objResult = await _context.PTLSitiosAP
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.SitioId == SitioId);
                return _mapper.Map<PTLSitiosAPModels>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("GetSitioById", ex, SitioId.ToString());
                throw;
            }
        }

        public async Task<PTLSitiosAPModels> PostInsertarSitios(PTLSitiosAPModels ObjInsertarSitio)
        {
            PTLSitiosAPEntities CreateRegistro = _mapper.Map<PTLSitiosAPEntities>(ObjInsertarSitio);
            try
            {
                _context.PTLSitiosAP.Add(CreateRegistro);
                await _context.SaveChangesAsync();
                var ObjResult = await _context.PTLSitiosAP.OrderByDescending(e => e.NombreSitio).FirstOrDefaultAsync();
                return _mapper.Map<PTLSitiosAPModels>(ObjInsertarSitio);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PostInsertarSitios", ex, JsonConvert.SerializeObject(ObjInsertarSitio));
                throw;
            }
        }
    }
}
