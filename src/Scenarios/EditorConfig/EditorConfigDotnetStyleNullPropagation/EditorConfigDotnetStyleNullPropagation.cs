namespace Testbed.EditorConfig.EditorConfigDotnetStyleNullPropagation;

public class EditorConfigDotnetStyleNullPropagation
{
    public string? Upper(string? value)
    {
        return value == null ? null : value.ToUpperInvariant();
    }

    public static string Run() => new EditorConfigDotnetStyleNullPropagation().Upper("ab") ?? "none";
}
