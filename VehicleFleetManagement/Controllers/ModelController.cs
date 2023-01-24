using Microsoft.AspNetCore.Mvc;
using VehicleFleetManagement.Interface;

namespace VehicleFleetManagement.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ModelController : ControllerBase
    {
        protected readonly IModelService _service;
        public ModelController(IModelService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<vfm.Model.ModelDto> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public vfm.Model.ModelDto GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet("{brandId}/model")]
        public IEnumerable<vfm.Model.ModelDto> GetByModel(int brandId)
        {
            return _service.GetByBrand(brandId);
        }       

    }
}
