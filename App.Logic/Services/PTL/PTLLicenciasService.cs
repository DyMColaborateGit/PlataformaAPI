using App.Infraestructure.IRepositories.PTL;
using App.Infraestructure.Repositories.PTL;
using App.logic.IServices.PTL;
using App.Models.Models.PTL;

namespace App.logic.Services.PTL
{
    public class PTLLicenciasService : IPTLLicenciasService
    {
        private readonly IPTLLicenciasRepository _PTLLicenciasRepository;

        public PTLLicenciasService(IPTLLicenciasRepository PTLLicenciasRepository)
        {
            _PTLLicenciasRepository = PTLLicenciasRepository;
        }

        public async Task<List<PTLLicenciasModels>> GetListLicencias()
        {
            return await _PTLLicenciasRepository.GetListLicencias();
        }

        public async Task<PTLLicenciasModels> GetLicenciaById(int LicenciaId)
        {
            return await _PTLLicenciasRepository.GetLicenciaById(LicenciaId);
        }

        public async Task<PTLLicenciasModels> PostInsertarLicencias(PTLLicenciasModels ObjInsertarLicencias, string NombreLicencia, string DescripcionLicencia, bool EstadoLicencia, DateTime FechaCreacion, DateTime FechaVencimiento)
        {
            ObjInsertarLicencias.NombreLicencia = NombreLicencia;
            ObjInsertarLicencias.DescripcionLicencia = DescripcionLicencia;
            ObjInsertarLicencias.EstadoLicencia = EstadoLicencia;
            ObjInsertarLicencias.FechaCreacion = FechaCreacion;
            ObjInsertarLicencias.FechaVencimiento = FechaVencimiento;

            return await _PTLLicenciasRepository.PostInsertarLicencias(ObjInsertarLicencias);
        }
        public async Task<PTLLicenciasModels> PutModificarLicencias(PTLLicenciasModels ObjModificarLicencias, string NombreLicencia, string DescripcionLicencia, bool EstadoLicencia, DateTime FechaCreacion, DateTime FechaVencimiento)
        {
            ObjModificarLicencias.NombreLicencia = NombreLicencia;
            ObjModificarLicencias.DescripcionLicencia = DescripcionLicencia;
            ObjModificarLicencias.EstadoLicencia = EstadoLicencia;
            ObjModificarLicencias.FechaCreacion = FechaCreacion;
            ObjModificarLicencias.FechaVencimiento = FechaVencimiento;

            return await _PTLLicenciasRepository.PutModificarLicencias(ObjModificarLicencias);
        }
        public async Task<PTLLicenciasModels> DeleteLicencias(int LicenciaId)
        {
            var ListResult = await _PTLLicenciasRepository.DeleteLicencias(LicenciaId);
            return ListResult;
        }
    }
}
