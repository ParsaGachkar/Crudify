namespace Crudify.Data.Abstraction;

public interface IGetPagedRepository<T>:IGetSortableRepository<T>
{
    public Task<IPagedIEnumerable<T>> GetPagedAsync(int pageNumber, int pageSize);
    public Task<IPagedIEnumerable<T>> GetSkipTakeAsync(int skip, int take);
}