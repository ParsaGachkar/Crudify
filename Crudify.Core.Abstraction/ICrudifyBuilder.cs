using Microsoft.Extensions.DependencyInjection;

namespace Crudify.Core.Abstraction;

public interface ICrudifyBuilder
{
public IServiceCollection Services { get; set; }
}