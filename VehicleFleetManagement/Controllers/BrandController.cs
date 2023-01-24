using Microsoft.AspNetCore.Mvc;
using VehicleFleetManagement.Interface;

namespace VehicleFleetManagement.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BrandController : ControllerBase
    {
        protected readonly IBrandService _service;
        public BrandController(IBrandService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<vfm.Model.BrandDto> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public vfm.Model.BrandDto GetById(int id)
        {
            return _service.GetById(id);
        }
        

    }
}
