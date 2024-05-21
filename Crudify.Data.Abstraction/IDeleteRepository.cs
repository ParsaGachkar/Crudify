namespace Crudify.Data.Abstraction;

public interface IDeleteRepository<T, in TId> where T : IHasId<TId> where TId : struct
{
    public Task<T> DeleteAsync(TId id);
}