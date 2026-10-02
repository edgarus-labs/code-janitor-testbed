namespace Testbed.EditorConfig.EditorConfigCA1507UseNameOf;

using System;

public class EditorConfigCA1507UseNameOf
{
    private static string Check(string? name)
    {
        if (name is null)
        {
            throw new ArgumentNullException("name");
        }

        return name;
    }

    public static string Run() => Check("n");
}
