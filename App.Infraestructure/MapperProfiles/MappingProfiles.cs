using App.Infraestructure.Connect.Entities.PTL;
using App.Models.Models.PTL;
using AutoMapper;

namespace App.Infraestructure.Profiles;

public class MappingProfiles: Profile
{
    public MappingProfiles() 
    {
        CreateMap<PTLSitiosEntities, PTLSitiosModels>().ReverseMap();
        CreateMap<PTLContentsELEntities, PTLContentsELModels>().ReverseMap();
        CreateMap<PTLEnlacesSTEntities, PTLEnlacesSTModels>().ReverseMap();

        CreateMap<PTLRolesEntities, PTLRolesModels>().ReverseMap();
        CreateMap<PTLUsuariosEntities, PTLUsuariosModels>().ReverseMap();
        CreateMap<PTLUsuariosRolesEntities, PTLUsuariosRolesModels>().ReverseMap();

        CreateMap<PTLAplicacionAPEntities, PTLAplicacionAPModels>().ReverseMap();
        CreateMap<PTLModulosAPEntities, PTLModulosAPModels>().ReverseMap();
        CreateMap<PTLVersionesAPEntities, PTLVersionesAPModels>().ReverseMap();
        CreateMap<PTLHelpDeskTicketAPEntities, PTLHelpDeskTicketAPModels>().ReverseMap();
        CreateMap<PTLRequerimientoHDEntities, PTLRequerimientoHDModels>().ReverseMap();
        CreateMap<PTLSeguimientoRQEntities, PTLSeguimientoRQModels>().ReverseMap();
        CreateMap<PTLUsuariosSTEntities,  PTLUsuariosSTModels>().ReverseMap();
        CreateMap<PTLSuscriptorAPEntities, PTLSuscriptorAPModels>().ReverseMap();
        CreateMap<PTLConexionesBDEntities,  PTLSuscriptorAPModels>().ReverseMap();
        CreateMap<PTLEmpresasSTEntities, PTLEmpresasSTModels>().ReverseMap();
        CreateMap<PTLUsuariosEmpresaEntities, PTLUsuariosEmpresaModels>().ReverseMap();
        CreateMap<PTLLicenciasSTEntities, PTLLicenciasSTModels>().ReverseMap();
        CreateMap<PTLPaquetesEntities, PTLPaquetesModels>().ReverseMap();
        CreateMap<PTLLogActualizacionesEntities, PTLLogActualizacionesModels>().ReverseMap();
        CreateMap<PTLLogActividadesAPEntities, PTLLogActualizacionesModels>().ReverseMap();
        CreateMap<PTLLogTransaccionesAPEntities, PTLLogTransaccionesAPModels>().ReverseMap();

    }
}
