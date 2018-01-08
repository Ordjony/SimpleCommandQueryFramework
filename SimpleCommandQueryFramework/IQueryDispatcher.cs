using System.Threading;
using System.Threading.Tasks;

namespace SimpleCommandQueryFramework
{
    public interface IQueryDispatcher
    {
        Task<TResult> ExecuteAsync<TQuery, TResult>(TQuery query, CancellationToken cancellationToken = default(CancellationToken))
            where TQuery : IQuery;
    }
}