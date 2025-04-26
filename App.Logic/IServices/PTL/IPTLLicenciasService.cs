using App.Models.Models.PTL;

namespace App.logic.IServices.PTL
{
    public interface IPTLLicenciasService
    {
        Task<List<PTLLicenciasModels>> GetListLicencias();
        Task<PTLLicenciasModels> GetLicenciaById(int LicenciaId);
        Task<PTLLicenciasModels> PostInsertarLicencias(PTLLicenciasModels ObjInsertarLicencias, string NombreLicencia, string DescripcionLicencia, bool EstadoLicencia, DateTime FechaCreacion, DateTime FechaVencimiento);
        Task<PTLLicenciasModels> PutModificarLicencias(PTLLicenciasModels ObjModificarLicencias, string NombreLicencia, string DescripcionLicencia, bool EstadoLicencia, DateTime FechaCreacion, DateTime FechaVencimiento);
        Task<PTLLicenciasModels> DeleteLicencias(int LicenciaId);
    }
}
