namespace Testbed.EditorConfig.EditorConfigCsharpPreferStaticAnonymousFunction;

using System;

public class EditorConfigCsharpPreferStaticAnonymousFunction
{
    public int Use(int x)
    {
        Func<int, int> twice = y => y * 2;

        return twice(x);
    }

    public static string Run() => new EditorConfigCsharpPreferStaticAnonymousFunction().Use(4).ToString();
}
