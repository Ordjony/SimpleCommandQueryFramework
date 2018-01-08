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

        public static IServiceCollection RegisterCommandHandler<TCommand, THandler>(this IServiceCollection serviceCollection)
            where TCommand : ICommand
            where THandler : class, ICommandHandler<TCommand>
        {
            serviceCollection.AddTransient<ICommandHandler<TCommand>, THandler>();

            return serviceCollection;
        }

        public static IServiceCollection RegisterQueryHandler<TQuery, TResult, THandler>(this IServiceCollection serviceCollection)
            where TQuery : IQuery
            where THandler : class, IQueryHandler<TQuery, TResult>
        {
            serviceCollection.AddTransient<IQueryHandler<TQuery, TResult>, THandler>();

            return serviceCollection;
        }
    }
}