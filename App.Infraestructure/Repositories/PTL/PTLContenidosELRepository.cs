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
    public class PTLContenidosELRepository : IPTLContenidosELRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLContenidosELRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLContenidosELModels>> GetListContenidos()
        {
            try
            {
                var objResult = await _context.PTLContenidosEL
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLContenidosELModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("GetListContenidos", ex, "");
                throw;
            }
        }

        public async Task<PTLContenidosELModels> GetContenidoById(int ContenidoId)
        {
            try
            {
                var objResult = await _context.PTLContenidosEL
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.ContenidoId == ContenidoId);
                return _mapper.Map<PTLContenidosELModels>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("GetContenidoById", ex, ContenidoId.ToString());
                throw;
            }
        }

        public async Task<PTLContenidosELModels> PostInsertarContenido(PTLContenidosELModels ObjInsertarContenido)
        {
            PTLContenidosELEntities CreateRegistro = _mapper.Map<PTLContenidosELEntities>(ObjInsertarContenido);
            try
            {
                _context.PTLContenidosEL.Add(CreateRegistro);
                await _context.SaveChangesAsync();
                var ObjResult = await _context.PTLContenidosEL.OrderByDescending(e => e.NombreContenido).FirstOrDefaultAsync();
                return _mapper.Map<PTLContenidosELModels>(ObjInsertarContenido);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PostInsertarContenido", ex, JsonConvert.SerializeObject(ObjInsertarContenido));
                throw;
            }
        }
        public async Task<PTLContenidosELModels> PutModificarContenido(PTLContenidosELModels ObjUpdate)
        {
            var UpdateRegistro = _context.PTLContenidosEL.FirstOrDefault(p => p.ContenidoId == ObjUpdate.ContenidoId);
            try
            {
                if (UpdateRegistro != null)
                {
                    #region Update
                    UpdateRegistro.NombreContenido = ObjUpdate.NombreContenido;
                    UpdateRegistro.DescripcionContenido = ObjUpdate.DescripcionContenido;
                    UpdateRegistro.Contenido = ObjUpdate.Contenido;
                    UpdateRegistro.EstadoContenido = ObjUpdate.EstadoContenido;
                    #endregion
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PutModificarContenido", ex, JsonConvert.SerializeObject(ObjUpdate));
                throw;
            }
            return _mapper.Map<PTLContenidosELModels>(UpdateRegistro);
        }
        public async Task<PTLContenidosELModels> DeleteContenido(int ContenidoId)
        {
            var objDelete = await _context.PTLContenidosEL.FirstOrDefaultAsync(x => x.ContenidoId == ContenidoId);

            try
            {
                if (objDelete != null)
                {
                    _context.PTLContenidosEL.Remove(objDelete);
                    await _context.SaveChangesAsync();
                }

                return _mapper.Map<PTLContenidosELModels>(objDelete);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("DeleteContenido", ex, ContenidoId.ToString());
                throw;
            }
        }
    }
}
