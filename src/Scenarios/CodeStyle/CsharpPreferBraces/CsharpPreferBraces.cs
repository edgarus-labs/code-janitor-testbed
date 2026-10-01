namespace Testbed.CodeStyle.CsharpPreferBraces;

using System;

public class CsharpPreferBraces
{
    public int Get(bool open)
    {
        if (open)
            return 1;
        for (var i = 0; i < 3; i++)
            Console.Write(string.Empty);
        return 0;
    }

    public static string Run() => new CsharpPreferBraces().Get(true).ToString();
}
