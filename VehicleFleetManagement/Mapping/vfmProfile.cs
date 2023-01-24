using AutoMapper;

namespace VehicleFleetManagement.Mapping;
public class vfmProfile : Profile
{
    public vfmProfile()
    {
        CreateMap<Models.Vehicle, vfm.Model.VehicleDto>();
        CreateMap<Models.Model, vfm.Model.ModelDto>();
        CreateMap<Models.Brand, vfm.Model.BrandDto>();
     
    }
}
