namespace VehicleFleetManagement.Interface
{
    public interface IReadService<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(int id);
       IEnumerable<T> GetByModel(int modelId);

    }
}
