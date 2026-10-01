namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferMethodGroupConversionDisabled;

using System;

public class EditorConfigCsharpStylePreferMethodGroupConversionDisabled
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

    public static string Run() => new EditorConfigCsharpStylePreferMethodGroupConversionDisabled().Apply(3).ToString();
}
