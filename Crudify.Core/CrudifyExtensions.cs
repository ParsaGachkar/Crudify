using Microsoft.Extensions.DependencyInjection;

namespace Crudify.Core;

public static class CrudifyExtensions
{
    public static ICrudifyBuilder AddCrudify(this IServiceCollection services)
    {
        return new CrudifyBuilder(services);
    }
}