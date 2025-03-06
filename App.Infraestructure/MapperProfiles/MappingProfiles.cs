using App.Infraestructure.Connect.Entities.PTL;
using App.Models.Models.PTL;
using AutoMapper;

namespace App.Infraestructure.Profiles;

public class MappingProfiles: Profile
{
    public MappingProfiles() 
    {
        CreateMap<PTLContentsELEntities, PTLContentsELModels>().ReverseMap();
        CreateMap<PTLEnlacesSTEntities, PTLEnlacesSTModels>().ReverseMap();
        CreateMap<PTLSitiosEntities, PTLSitiosModels>().ReverseMap();
        CreateMap<PTLAplicacionAPEntities, PTLAplicacionAPModels>().ReverseMap();
    }
}
