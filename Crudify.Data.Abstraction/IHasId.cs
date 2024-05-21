namespace Crudify.Data.Abstraction;

public interface IHasId<T>
{
    T Id { get; set; }
}