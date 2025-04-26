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
    public class PTLLicenciasRepository : IPTLLicenciasRepository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLLicenciasRepository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLLicenciasModels>> GetListLicencias()
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
                ExceptionLogHelpers.LogException("GetListLicencias", ex, "");
                throw;
            }
        }

        public async Task<PTLLicenciasModels> GetLicenciaById(int LicenciaId)
        {
            try
            {
                var objResult = await _context.PTLLicencias
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.LicenciaId == LicenciaId);
                return _mapper.Map<PTLLicenciasModels>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("GetLicenciaById", ex, LicenciaId.ToString());
                throw;
            }
        }

        public async Task<PTLLicenciasModels> PostInsertarLicencias(PTLLicenciasModels ObjInsertarLicencias)
        {
            PTLLicenciasEntities CreateRegistro = _mapper.Map<PTLLicenciasEntities>(ObjInsertarLicencias);
            try
            {
                _context.PTLLicencias.Add(CreateRegistro);
                await _context.SaveChangesAsync();
                var ObjResult = await _context.PTLLicencias.OrderByDescending(e => e.NombreLicencia).FirstOrDefaultAsync();
                return _mapper.Map<PTLLicenciasModels>(ObjInsertarLicencias);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PostInsertarLicencias", ex, JsonConvert.SerializeObject(ObjInsertarLicencias));
                throw;
            }
        }
        public async Task<PTLLicenciasModels> PutModificarLicencias(PTLLicenciasModels ObjUpdate)
        {
            var UpdateRegistro = _context.PTLLicencias.FirstOrDefault(p => p.LicenciaId == ObjUpdate.LicenciaId);
            try
            {
                if (UpdateRegistro != null)
                {
                    #region Update
                    UpdateRegistro.NombreLicencia = ObjUpdate.NombreLicencia;
                    UpdateRegistro.DescripcionLicencia = ObjUpdate.DescripcionLicencia;
                    UpdateRegistro.EstadoLicencia = ObjUpdate.EstadoLicencia;
                    UpdateRegistro.FechaCreacion = ObjUpdate.FechaCreacion;
                    UpdateRegistro.FechaVencimiento = ObjUpdate.FechaVencimiento;
                    #endregion
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PutModificarLicencias", ex, JsonConvert.SerializeObject(ObjUpdate));
                throw;
            }
            return _mapper.Map<PTLLicenciasModels>(UpdateRegistro);
        }
        public async Task<PTLLicenciasModels> DeleteLicencias(int LicenciaId)
        {
            var objDelete = await _context.PTLLicencias.FirstOrDefaultAsync(x => x.LicenciaId == LicenciaId);

            try
            {
                if (objDelete != null)
                {
                    _context.PTLLicencias.Remove(objDelete);
                    await _context.SaveChangesAsync();
                }

                return _mapper.Map<PTLLicenciasModels>(objDelete);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("DeleteLicencias", ex, LicenciaId.ToString());
                throw;
            }
        }
    }
}
