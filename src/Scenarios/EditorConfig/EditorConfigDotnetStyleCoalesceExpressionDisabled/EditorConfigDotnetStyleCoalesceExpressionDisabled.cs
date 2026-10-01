namespace Testbed.EditorConfig.EditorConfigDotnetStyleCoalesceExpressionDisabled;

public class EditorConfigDotnetStyleCoalesceExpressionDisabled
{
    public string Coalesce(string? value)
    {
        return value != null ? value : "";
    }

    public static string Run() => new EditorConfigDotnetStyleCoalesceExpressionDisabled().Coalesce(null) + "|" + new EditorConfigDotnetStyleCoalesceExpressionDisabled().Coalesce("a");
}
