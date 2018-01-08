using System.Threading;
using System.Threading.Tasks;

namespace SimpleCommandQueryFramework
{
    public interface ICommandHandler<in TCommand>
        where TCommand : ICommand
    {
        Task ExecuteAsync(TCommand command, CancellationToken cancellationToken);
    }
}
