using App.Infraestructure.Connect.Entities.PTL;
using App.Models.Models.PTL;
using AutoMapper;

namespace App.Infraestructure.Profiles;

public class MappingProfiles: Profile
{
    public MappingProfiles() 
    {
        CreateMap<PTLSitiosAPEntities, PTLSitiosAPModels>().ReverseMap();
        CreateMap<PTLContenidoELEntities, PTLContenidoELModels>().ReverseMap();
        CreateMap<PTLEnlacesSTEntities, PTLEnlacesSTModels>().ReverseMap();

        CreateMap<PTLRolesAPEntities, PTLRolesAPModels>().ReverseMap();
        CreateMap<PTLUsuariosAPEntities, PTLUsuariosAPModels>().ReverseMap();
        CreateMap<PTLUsuariosRolesEntities, PTLUsuariosRolesModels>().ReverseMap();

        CreateMap<PTLAplicacionEntities, PTLAplicacionModels>().ReverseMap();
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
        CreateMap<PTLLicenciasEntities, PTLLicenciasModels>().ReverseMap();
        CreateMap<PTLPaquetesEntities, PTLPaquetesModels>().ReverseMap();
        CreateMap<PTLLogActualizacionesEntities, PTLLogActualizacionesModels>().ReverseMap();
        CreateMap<PTLLogActividadesAPEntities, PTLLogActualizacionesModels>().ReverseMap();
        CreateMap<PTLLogTransaccionesAPEntities, PTLLogTransaccionesAPModels>().ReverseMap();

    }
}
