namespace Testbed.EditorConfig.EditorConfigDotnetStylePredefinedTypeForMemberAccessDisabled;

using System;

public class EditorConfigDotnetStylePredefinedTypeForMemberAccessDisabled
{
    public string Join(string[] parts)
    {
        return String.Join(",", parts) + Int32.MaxValue.ToString();
    }

    public static string Run() => new EditorConfigDotnetStylePredefinedTypeForMemberAccessDisabled().Join(new[] { "a", "b" });
}
