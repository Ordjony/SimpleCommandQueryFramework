using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleCommandQueryFramework
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public QueryDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<TResult> ExecuteAsync<TQuery, TResult>(TQuery query, CancellationToken cancellationToken = default(CancellationToken))
            where TQuery : IQuery
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            var handler = _serviceProvider.GetService<IQueryHandler<TQuery, TResult>>();
            return handler.ExecuteAsync(query, cancellationToken);
        }
    }
}
