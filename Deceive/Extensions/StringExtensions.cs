using Deceive.Enums;
using System;

namespace Deceive.Extensions;
internal static class StringExtensions
{
    internal static bool IsCommand(this string content, DecieveChatCommand type)
    {
        return content.Contains(type.ToString(), StringComparison.OrdinalIgnoreCase);
    }
}
