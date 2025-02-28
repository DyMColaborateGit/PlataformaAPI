using App.Infraestructure.Connect.Entities.PTL;
using App.Models.Models.PTL;
using AutoMapper;

namespace App.Infraestructure.Profiles;

public class MappingProfiles: Profile
{
    public MappingProfiles() 
    {
        CreateMap<PTLContenidosELEntities, PTLContenidosELModels>().ReverseMap();
        CreateMap<PTLEnlacesSTEntities, PTLEnlacesSTModels>().ReverseMap();
        CreateMap<PTLSitiosEntities, PTLSitiosModels>().ReverseMap();

        CreateMap<PruebaEntities, PruebaModels>().ReverseMap();
    }
}
