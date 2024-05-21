namespace Crudify.Data.Abstraction;

public interface IGetByIdRepository<T, in TId> where T : IHasId<TId> where TId : struct
{
    public Task<T> GetAsync(TId id);
}