using VehicleFleetManagement.Models;

namespace VehicleFleetManagement.Interface;
public interface IModelService : IReadService<vfm.Model.ModelDto>
{
      
    IEnumerable<vfm.Model.ModelDto> GetByBrand(int brandId);
}
