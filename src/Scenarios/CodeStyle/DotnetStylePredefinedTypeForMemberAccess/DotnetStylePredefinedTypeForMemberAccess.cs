namespace Testbed.CodeStyle.DotnetStylePredefinedTypeForMemberAccess;

using System;

public class DotnetStylePredefinedTypeForMemberAccess
{
    public string Join(string[] parts)
    {
        return String.Join(",", parts) + Int32.MaxValue.ToString();
    }

    public static string Run() => new DotnetStylePredefinedTypeForMemberAccess().Join(new[] { "a", "b" });
}
