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
    public class PTLRolesAPRespository : IPTLRolesAPRespository
    {
        private readonly ConnectContext _context;
        private readonly IMapper _mapper;

        public PTLRolesAPRespository(ConnectContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PTLRolesAPModels>> GetListRoles()
        {
            try
            {
                var objResult = await _context.PTLRolesAP
                    .AsNoTracking()
                    .ToListAsync();
                return _mapper.Map<List<PTLRolesAPModels>>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("GetListRoles", ex, "");
                throw;
            }
        }

        public async Task<PTLRolesAPModels> GetRolesById(int RolId)
        {
            try
            {
                var objResult = await _context.PTLRolesAP
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.RolId == RolId);
                return _mapper.Map<PTLRolesAPModels>(objResult);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("GetRolesById", ex, RolId.ToString());
                throw;
            }
        }

        public async Task<PTLRolesAPModels> PostInsertarRoles(PTLRolesAPModels ObjInsertarRoles)
        {
            PTLRolesAPEntities CreateRegistro = _mapper.Map<PTLRolesAPEntities>(ObjInsertarRoles);
            try
            {
                _context.PTLRolesAP.Add(CreateRegistro);
                await _context.SaveChangesAsync();
                var ObjResult = await _context.PTLRolesAP.OrderByDescending(e => e.NombreRol).FirstOrDefaultAsync();
                return _mapper.Map<PTLRolesAPModels>(ObjInsertarRoles);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PostInsertarRoles", ex, JsonConvert.SerializeObject(ObjInsertarRoles));
                throw;
            }
        }
        public async Task<PTLRolesAPModels> PutModificarRoles(PTLRolesAPModels ObjUpdate)
        {
            var UpdateRegistro = _context.PTLRolesAP.FirstOrDefault(p => p.RolId == ObjUpdate.RolId);
            try
            {
                if (UpdateRegistro != null)
                {
                    #region Update
                    UpdateRegistro.NombreRol = ObjUpdate.NombreRol;
                    UpdateRegistro.DescripcionRol = ObjUpdate.DescripcionRol;
                    UpdateRegistro.EstadoRol = ObjUpdate.EstadoRol;
                    #endregion
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("PutModificarRoles", ex, JsonConvert.SerializeObject(ObjUpdate));
                throw;
            }
            return _mapper.Map<PTLRolesAPModels>(UpdateRegistro);
        }
        public async Task<PTLRolesAPModels> DeleteRoles(int RolId)
        {
            var objDelete = await _context.PTLRolesAP.FirstOrDefaultAsync(x => x.RolId == RolId);

            try
            {
                if (objDelete != null)
                {
                    _context.PTLRolesAP.Remove(objDelete);
                    await _context.SaveChangesAsync();
                }

                return _mapper.Map<PTLRolesAPModels>(objDelete);
            }
            catch (Exception ex)
            {
                ExceptionLogHelpers.LogException("DeleteRoles", ex, RolId.ToString());
                throw;
            }
        }
    }
}
