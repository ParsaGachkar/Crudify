namespace Crudify.Data.Abstraction;

public interface ISpecification<T>
{
    public Predicate<T> GetPredicate();
}