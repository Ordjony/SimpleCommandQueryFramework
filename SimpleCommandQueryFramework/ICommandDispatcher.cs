using System.Threading;
using System.Threading.Tasks;

namespace SimpleCommandQueryFramework
{
    public interface ICommandDispatcher
    {
        Task Execute<TCommand>(TCommand command, CancellationToken cancellationToken)
            where TCommand : ICommand;
    }
}