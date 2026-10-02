namespace Testbed.EditorConfig.EditorConfigDotnetStyleCoalesceExpression;

public class EditorConfigDotnetStyleCoalesceExpression
{
    public string Coalesce(string? value)
    {
        return value != null ? value : "";
    }

    public static string Run() => new EditorConfigDotnetStyleCoalesceExpression().Coalesce(null) + "|" + new EditorConfigDotnetStyleCoalesceExpression().Coalesce("a");
}
