using System.Threading.Tasks;

namespace Deceive.Commands;
internal class CommandInvoker(ICommand command)
{
    public async Task ExecuteAsync()
    {
       await command.ExecuteAsync();
    }
}
