using System.Threading.Tasks;

namespace Deceive.Commands;
internal interface ICommand
{
    Task ExecuteAsync();
}
