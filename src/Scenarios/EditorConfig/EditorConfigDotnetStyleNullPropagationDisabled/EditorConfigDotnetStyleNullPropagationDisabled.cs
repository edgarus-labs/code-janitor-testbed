namespace Testbed.EditorConfig.EditorConfigDotnetStyleNullPropagationDisabled;

public class EditorConfigDotnetStyleNullPropagationDisabled
{
    public string? Upper(string? value)
    {
        return value == null ? null : value.ToUpperInvariant();
    }

    public static string Run() => new EditorConfigDotnetStyleNullPropagationDisabled().Upper("ab") ?? "none";
}
