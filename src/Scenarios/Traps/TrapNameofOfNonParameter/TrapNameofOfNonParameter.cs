namespace Testbed.Traps.TrapNameofOfNonParameter;

using System;

public class TrapNameofOfNonParameter
{
    private static string Check(string value, string other)
    {
        if (value is null)
        {
            throw new ArgumentNullException("missing");
        }

        return value + other;
    }

    public static string Run() => Check("a", "b");
}
