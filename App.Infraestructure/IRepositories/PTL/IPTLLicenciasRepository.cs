using App.Models.Models.PTL;

namespace App.Infraestructure.IRepositories.PTL
{
    public interface IPTLLicenciasRepository
    {
        Task<List<PTLLicenciasModels>> GetListLicencias();
        Task<PTLLicenciasModels> GetLicenciaById(int LicenciaId);
        Task<PTLLicenciasModels> PostInsertarLicencias(PTLLicenciasModels ObjInsertarLicencias);
        Task<PTLLicenciasModels> PutModificarLicencias(PTLLicenciasModels ObjModificarLicencias);
        Task<PTLLicenciasModels> DeleteLicencias(int LicenciaId);

    }
}
