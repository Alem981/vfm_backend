using AutoMapper;
using VehicleFleetManagement.Data;
using VehicleFleetManagement.Interface;
using VehicleFleetManagement.Models;

namespace VehicleFleetManagement.Services;

public class BrandService : BaseReadService<vfm.Model.BrandDto, Brand>,  IBrandService
{
    public BrandService(DataContext context, IMapper mapper)
           : base(context, mapper)
    {
    }

    public IEnumerable<vfm.Model.BrandDto> Get()
    {
        return Context.Brands.ToList().Select(x => _mapper.Map<vfm.Model.BrandDto>(x)).ToList();
    }

    public vfm.Model.BrandDto GetById(int id)
    {
        var entity = Context.Brands.Find(id);
        return _mapper.Map<vfm.Model.BrandDto>(entity);
    }
}

