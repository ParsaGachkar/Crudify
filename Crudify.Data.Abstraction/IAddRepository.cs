namespace Crudify.Data.Abstraction;

public interface IAddRepository<in T>
{
    public Task AddAsync(T entity);
}