using AutoMapper;
using System.Collections.Generic;
using VehicleFleetManagement.Data;
using VehicleFleetManagement.Interface;
using VehicleFleetManagement.Models;

namespace VehicleFleetManagement.Services
{
    public class BaseReadService<T, TDb> : IReadService<T> where T : class where TDb: class
    {

        public DataContext Context { get; set; }
        protected readonly IMapper _mapper;
        public BaseReadService(DataContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }


        public IEnumerable<T> Get()
        {
            var entity = Context.Set<TDb>();
            var list = entity.ToList();
            return _mapper.Map<List<T>>(list); 
        }

        public T GetById(int id)
        {
            var set = Context.Set<TDb>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }

          public IEnumerable<T> GetByModel(int modelId)
        {            
            return (IEnumerable<T>)Context.Vehicles.Where(x => x.ModelId == modelId).ToList().Select(x => _mapper.Map<vfm.Model.VehicleDto>(x)).ToList();;
        }
    }
}
