namespace Crudify.Data.Abstraction;

public interface ISoftDelete
{
    bool Deleted { get; set; }
}