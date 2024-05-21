using System.Linq.Expressions;

namespace Crudify.Data.Abstraction;

public interface IGetFilteredRepository<T>
{
    public Task<IEnumerable<T>> GetFilteredAsync(Expression<Func<T, bool>>? filter);
}