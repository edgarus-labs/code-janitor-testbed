namespace Testbed.EditorConfig.EditorConfigCsharpPreferBracesDisabled;

using System;

public class EditorConfigCsharpPreferBracesDisabled
{
    public int Get(bool open)
    {
        if (open)
            return 1;
        for (var i = 0; i < 3; i++)
            Console.Write(string.Empty);
        return 0;
    }

    public static string Run() => new EditorConfigCsharpPreferBracesDisabled().Get(true).ToString();
}
