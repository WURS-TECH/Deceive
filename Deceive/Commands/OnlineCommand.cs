﻿using System.Threading.Tasks;

namespace Deceive.Commands;
internal class OnlineCommand(MainController mainController) : Command(mainController)
{
    internal async override Task ExecuteAsync()
    {
        if (!_mainController.Enabled)
            await Utils.SendMessageFromFakePlayerAsync("Deceive is now enabled.", _mainController.Connections);
        _mainController.ChatStatus.PerformClick();
    }
}
