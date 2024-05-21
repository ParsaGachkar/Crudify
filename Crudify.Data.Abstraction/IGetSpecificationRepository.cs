namespace Crudify.Data.Abstraction;

public interface IGetSpecificationRepository<T>
{
    public Task<IEnumerable<T>> GetSpecificationAsync(ISpecification<T> specification);
}