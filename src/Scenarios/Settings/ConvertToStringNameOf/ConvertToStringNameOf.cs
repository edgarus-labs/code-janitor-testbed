namespace Testbed.Settings.ConvertToStringNameOf;

using System;

public class ConvertToStringNameOf
{
    public static string Run() => Check("n");

    private static string Check(string? name)
    {
        if (name is null)
        {
            throw new ArgumentNullException("name");
        }

        return name;
    }
}
