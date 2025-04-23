using App.Infraestructure.Connect.Entities.PTL;
using App.Models.Models.PTL;
using AutoMapper;

namespace App.Infraestructure.Profiles;

public class MappingProfiles: Profile
{
    public MappingProfiles() 
    {
        CreateMap<PTLSitiosAPEntities, PTLSitiosAPModels>().ReverseMap();
        CreateMap<PTLContenidosELEntities, PTLContenidosELModels>().ReverseMap();
        CreateMap<PTLEnlacesSTEntities, PTLEnlacesSTModels>().ReverseMap();

        CreateMap<PTLRolesAPEntities, PTLRolesAPModels>().ReverseMap();
        CreateMap<PTLUsuariosAPEntities, PTLUsuariosAPModels>().ReverseMap();
        CreateMap<PTLUsuariosRolesEntities, PTLUsuariosRolesModels>().ReverseMap();

        CreateMap<PTLAplicacionesEntities, PTLAplicacionesModels>().ReverseMap();
        CreateMap<PTLModulosAPEntities, PTLModulosAPModels>().ReverseMap();
        CreateMap<PTLVersionesAPEntities, PTLVersionesAPModels>().ReverseMap();
        CreateMap<PTLHelpDeskTicketsAPEntities, PTLHelpDeskTicketsAPModels>().ReverseMap();
        CreateMap<PTLRequerimientosHDEntities, PTLRequerimientosHDModels>().ReverseMap();
        CreateMap<PTLSeguimientosRQEntities, PTLSeguimientosRQModels>().ReverseMap();
        CreateMap<PTLUsuariosSTEntities,  PTLUsuariosSTModels>().ReverseMap();
        CreateMap<PTLSuscriptoresAPEntities, PTLSuscriptoresAPModels>().ReverseMap();
        CreateMap<PTLConexionesBDEntities,  PTLSuscriptoresAPModels>().ReverseMap();
        CreateMap<PTLEmpresasSTEntities, PTLEmpresasSTModels>().ReverseMap();
        CreateMap<PTLUsuariosEmpresaEntities, PTLUsuariosEmpresasModels>().ReverseMap();
        CreateMap<PTLLicenciasEntities, PTLLicenciasModels>().ReverseMap();
        CreateMap<PTLPaquetesEntities, PTLPaquetesModels>().ReverseMap();
        CreateMap<PTLLogActualizacionesEntities, PTLLogActualizacionesModels>().ReverseMap();
        CreateMap<PTLLogActividadesAPEntities, PTLLogActualizacionesModels>().ReverseMap();
        CreateMap<PTLLogTransaccionesAPEntities, PTLLogTransaccionesAPModels>().ReverseMap();

    }
}
