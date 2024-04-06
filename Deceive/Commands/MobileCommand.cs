using System.Threading.Tasks;

namespace Deceive.Commands;
internal class MobileCommand(MainController mainController) : Command(mainController)
{
    internal async override Task ExecuteAsync()
    {
        if (!_mainController.Enabled)
            await SendMessageFromFakePlayerAsync("Deceive is now enabled.");
        _mainController.MobileStatus.PerformClick();
    }
}
