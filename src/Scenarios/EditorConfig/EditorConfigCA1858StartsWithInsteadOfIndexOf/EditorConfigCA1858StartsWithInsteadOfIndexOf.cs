namespace Testbed.EditorConfig.EditorConfigCA1858StartsWithInsteadOfIndexOf;

using System;

public class EditorConfigCA1858StartsWithInsteadOfIndexOf
{
    public static string Run()
    {
        var text = "abc";

        return (text.IndexOf("a", StringComparison.Ordinal) == 0).ToString();
    }
}
