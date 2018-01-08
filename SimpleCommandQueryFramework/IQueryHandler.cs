using System.Threading;
using System.Threading.Tasks;

namespace SimpleCommandQueryFramework
{
    public interface IQueryHandler<in TQuery, TResult>
        where TQuery : IQuery
    {
        Task<TResult> ExecuteAsync(TQuery query, CancellationToken cancellationToken);
    }
}
