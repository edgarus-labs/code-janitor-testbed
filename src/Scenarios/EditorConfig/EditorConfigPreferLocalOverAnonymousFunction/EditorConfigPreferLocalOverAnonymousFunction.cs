namespace Testbed.EditorConfig.EditorConfigPreferLocalOverAnonymousFunction;

using System;

public class EditorConfigPreferLocalOverAnonymousFunction
{
    public static string Run()
    {
        Func<int, int> twice = x => x * 2;

        return twice(4).ToString();
    }
}
