namespace Testbed.CodeStyle.CsharpPreferStaticAnonymousFunction;

using System;

public class CsharpPreferStaticAnonymousFunction
{
    public int Use(int x)
    {
        Func<int, int> twice = y => y * 2;

        return twice(x);
    }

    public static string Run() => new CsharpPreferStaticAnonymousFunction().Use(4).ToString();
}
