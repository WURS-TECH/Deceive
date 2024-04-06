using System.Threading.Tasks;

namespace Deceive.Commands;
internal class DisableCommand(MainController mainController) : Command(mainController)
{
    internal async override Task ExecuteAsync()
    {
        if (!_mainController.Enabled)
            await Utils.SendMessageFromFakePlayerAsync("Deceive is already disabled.", _mainController.Connections);
        else
            _mainController.EnabledMenuItem.PerformClick();
    }
}
