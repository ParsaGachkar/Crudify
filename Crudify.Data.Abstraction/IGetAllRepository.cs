namespace Crudify.Data.Abstraction;

public interface IGetAllRepository<T>
{
    public Task<IEnumerable<T>> GetAllAsync();
}