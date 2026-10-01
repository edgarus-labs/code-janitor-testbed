namespace Testbed.EditorConfig.EditorConfigCA1865CA1866CA1867CharOverloads;

using System;

public class EditorConfigCA1865CA1866CA1867CharOverloads
{
    public static string Run()
    {
        var text = "abc";
        var ordinal = text.StartsWith("a", StringComparison.Ordinal);
        var culture = text.StartsWith("b");
        var ignoreCase = text.StartsWith("c", StringComparison.OrdinalIgnoreCase);

        return ordinal + "," + culture + "," + ignoreCase;
    }
}
