namespace Testbed.CodeStyle.CsharpStylePreferMethodGroupConversion;

using System;

public class CsharpStylePreferMethodGroupConversion
{
    public int Apply(int value)
    {
        Func<int, int> convert = v => Double(v);

        return convert(value);
    }

    private static int Double(int value)
    {
        return value * 2;
    }

    public static string Run() => new CsharpStylePreferMethodGroupConversion().Apply(3).ToString();
}
