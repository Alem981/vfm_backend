using Microsoft.AspNetCore.Mvc;
using VehicleFleetManagement.Interface;

namespace VehicleFleetManagement.Controllers;

[ApiController]
[Route("[Controller]")]
public class VehicleController : ControllerBase
{
    protected readonly IVehicleService _service;
    public VehicleController(IVehicleService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<vfm.Model.VehicleDto> Get()
    {
        return _service.Get();
    }
    [HttpGet("{id}")]
    public vfm.Model.VehicleDto GetById(int id)
    {
        return _service.GetById(id);
    }
    [HttpGet("{modelId}/vehicle")]
    public IEnumerable<vfm.Model.VehicleDto> GetByModel(int modelId)
    {
        return _service.GetByModel(modelId);
    }

}
