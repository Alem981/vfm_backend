using AutoMapper;
using VehicleFleetManagement.Data;
using VehicleFleetManagement.Interface;
using VehicleFleetManagement.Models;

namespace VehicleFleetManagement.Services;
public class ModelService : BaseReadService<vfm.Model.ModelDto, Model>, IModelService
{
    public ModelService(DataContext context, IMapper mapper)
         : base(context, mapper)
    {
    }    
        public IEnumerable<vfm.Model.ModelDto> GetByBrand(int brandId)
        {
            return Context.Models.Where(x => x.BrandId == brandId).ToList().Select(x => _mapper.Map<vfm.Model.ModelDto>(x)).ToList(); ;

        }
  }

