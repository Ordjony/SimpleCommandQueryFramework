using Microsoft.Extensions.DependencyInjection;

namespace SimpleCommandQueryFramework
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterCommandQueryFramework(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ICommandDispatcher, CommandDispatcher>();
            serviceCollection.AddSingleton<IQueryDispatcher, QueryDispatcher>();

            return serviceCollection;
        }
    }
}
