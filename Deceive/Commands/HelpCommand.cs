using System.Threading.Tasks;

namespace Deceive.Commands;
internal class HelpCommand(MainController mainController) : Command(mainController)
{
    internal async override Task ExecuteAsync()
    {
        await SendMessageFromFakePlayerAsync("You can send the following messages to quickly change Deceive settings: online/offline/mobile/enable/disable/status");
    }
}
