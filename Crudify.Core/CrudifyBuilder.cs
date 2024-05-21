using Crudify.Core.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace Crudify.Core;

public class CrudifyBuilder(IServiceCollection services) : ICrudifyBuilder
{
}