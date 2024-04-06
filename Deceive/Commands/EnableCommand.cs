using System.Threading.Tasks;

namespace Deceive.Commands;
internal class EnableCommand(MainController mainController) : Command(mainController)
{
    internal async override Task ExecuteAsync()
    {
        if (_mainController.Enabled)
            await SendMessageFromFakePlayerAsync("Deceive is already enabled.");
        else
            _mainController.EnabledMenuItem.PerformClick();
    }
}
