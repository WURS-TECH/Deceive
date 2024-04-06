using System.Threading.Tasks;

namespace Deceive.Commands;
internal class StatusCommand(MainController mainController) : Command(mainController)
{
    internal async override Task ExecuteAsync()
    {
        if (_mainController.Status == "chat")
            await SendMessageFromFakePlayerAsync("You are appearing online.");
        else
            await SendMessageFromFakePlayerAsync("You are appearing " + _mainController.Status + ".");
    }
}
