namespace Testbed.EditorConfig.EditorConfigPreferImplicitlyTypedLambda;

using System;

public class EditorConfigPreferImplicitlyTypedLambda
{
    public static string Run()
    {
        Func<int, int> twice = (int x) => x * 2;

        return twice(4).ToString();
    }
}
