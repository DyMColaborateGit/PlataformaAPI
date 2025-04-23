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
    public class PTLEnlacesSTRepository : IPTLEnlacesSTRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLEnlacesSTRepository(ConnectContext context, IMapper mapper)
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

        public async Task<PTLEnlacesSTModels> GetEnlaceById(int EnlaceId)
        {
            try
            {
                var objResult = await _context.PTLEnlacesST
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.EnlaceId == EnlaceId);
                return _mapper.Map<PTLEnlacesSTModels>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("GetEnlaceById", ex, EnlaceId.ToString());
                throw;
            }
        }

        public async Task<PTLEnlacesSTModels> PostInsertarEnlace(PTLEnlacesSTModels ObjInsertarEnlace)
        {
            PTLEnlacesSTEntities CreateRegistro = _mapper.Map<PTLEnlacesSTEntities>(ObjInsertarEnlace);
            try
            {
                _context.PTLEnlacesST.Add(CreateRegistro);
                await _context.SaveChangesAsync();
                var ObjResult = await _context.PTLEnlacesST.OrderByDescending(e => e.NombreEnlace).FirstOrDefaultAsync();
                return _mapper.Map<PTLEnlacesSTModels>(ObjInsertarEnlace);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PostInsertarEnlace", ex, JsonConvert.SerializeObject(ObjInsertarEnlace));
                throw;
            }
        }
        public async Task<PTLEnlacesSTModels> PutModificarEnlace(PTLEnlacesSTModels ObjUpdate)
        {
            var UpdateRegistro = _context.PTLEnlacesST.FirstOrDefault(p => p.EnlaceId == ObjUpdate.EnlaceId);
            try
            {
                if (UpdateRegistro != null)
                {
                    #region Update
                    UpdateRegistro.NombreEnlace = ObjUpdate.NombreEnlace;
                    UpdateRegistro.DescripcionEnlace = ObjUpdate.DescripcionEnlace;
                    UpdateRegistro.RutaEnlace = ObjUpdate.RutaEnlace;
                    UpdateRegistro.EstadoEnlace = ObjUpdate.EstadoEnlace;
                    #endregion
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PutModificarEnlace", ex, JsonConvert.SerializeObject(ObjUpdate));
                throw;
            }
            return _mapper.Map<PTLEnlacesSTModels>(UpdateRegistro);
        }
        public async Task<PTLEnlacesSTModels> DeleteEnlace(int EnlaceId)
        {
            var objDelete = await _context.PTLEnlacesST.FirstOrDefaultAsync(x => x.EnlaceId == EnlaceId);

            try
            {
                if (objDelete != null)
                {
                    _context.PTLEnlacesST.Remove(objDelete);
                    await _context.SaveChangesAsync();
                }

                return _mapper.Map<PTLEnlacesSTModels>(objDelete);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("DeleteEnlace", ex, EnlaceId.ToString());
                throw;
            }
        }
    }
}
