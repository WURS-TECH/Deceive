using System.Threading.Tasks;

namespace Deceive.Commands;
internal class StatusCommand(MainController mainController) : Command(mainController)
{
    internal async override Task ExecuteAsync()
    {
        if (_mainController.Status == "chat")
            await Utils.SendMessageFromFakePlayerAsync("You are appearing online.", _mainController.Connections);
        else
            await Utils.SendMessageFromFakePlayerAsync($"You are appearing {_mainController.Status}.", _mainController.Connections);
    }
}
