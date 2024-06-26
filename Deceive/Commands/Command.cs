﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Deceive.Commands;
internal abstract class Command(MainController mainController) : ICommand
{
    protected readonly MainController _mainController = mainController;
    internal abstract Task ExecuteAsync();

    async Task ICommand.ExecuteAsync()
    {
        await ExecuteAsync();
    }
}
