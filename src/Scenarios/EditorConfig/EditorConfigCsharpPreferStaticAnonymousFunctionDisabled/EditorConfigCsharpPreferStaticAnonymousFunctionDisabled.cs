namespace Testbed.EditorConfig.EditorConfigCsharpPreferStaticAnonymousFunctionDisabled;

using System;

public class EditorConfigCsharpPreferStaticAnonymousFunctionDisabled
{
    public int Use(int x)
    {
        Func<int, int> twice = y => y * 2;

        return twice(x);
    }

    public static string Run() => new EditorConfigCsharpPreferStaticAnonymousFunctionDisabled().Use(4).ToString();
}
