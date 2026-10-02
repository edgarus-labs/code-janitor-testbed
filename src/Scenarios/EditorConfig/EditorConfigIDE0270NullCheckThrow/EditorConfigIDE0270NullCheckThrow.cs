namespace Testbed.EditorConfig.EditorConfigIDE0270NullCheckThrow;

using System;

public class EditorConfigIDE0270NullCheckThrow
{
    private static string Get() => "a";

    public static string Run()
    {
        string text = Get();
        if (text == null)
        {
            throw new InvalidOperationException();
        }

        return text;
    }
}
