namespace Crudify.Data.Abstraction;

public interface IUpdateRepository<T, in TId> where T : IHasId<TId> where TId : struct
{
    public Task<T> UpdateAsync(TId id, T entity);
}