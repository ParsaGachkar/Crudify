using System.ComponentModel;

namespace Crudify.Data.Abstraction;

public interface IGetSortableRepository<T>
{
    public ListSortDescription DefaultSorting { get; }
    public Task<IOrderedEnumerable<T>> GetSortedAsync(ListSortDescription? sortDescription);
}