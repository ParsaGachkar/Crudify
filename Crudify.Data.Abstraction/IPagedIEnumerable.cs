namespace Crudify.Data.Abstraction;

public interface IPagedIEnumerable<T>:IEnumerable<T>
{
    public int PageNumber { get; }
    public int Skip { get; }
    public int Take { get; }
    public int TotalCount { get; }
}