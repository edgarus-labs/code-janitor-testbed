namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferMethodGroupConversion;

using System;

public class EditorConfigCsharpStylePreferMethodGroupConversion
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

    public static string Run() => new EditorConfigCsharpStylePreferMethodGroupConversion().Apply(3).ToString();
}
