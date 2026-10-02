namespace Testbed.EditorConfig.EditorConfigDotnetStylePredefinedTypeForMemberAccess;

using System;

public class EditorConfigDotnetStylePredefinedTypeForMemberAccess
{
    public string Join(string[] parts)
    {
        return String.Join(",", parts) + Int32.MaxValue.ToString();
    }

    public static string Run() => new EditorConfigDotnetStylePredefinedTypeForMemberAccess().Join(new[] { "a", "b" });
}
