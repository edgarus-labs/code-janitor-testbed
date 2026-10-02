namespace Testbed.CodeStyle.DotnetStyleCoalesceExpression;

public class DotnetStyleCoalesceExpression
{
    public string Coalesce(string? value)
    {
        return value != null ? value : "";
    }

    public static string Run() => new DotnetStyleCoalesceExpression().Coalesce(null) + "|" + new DotnetStyleCoalesceExpression().Coalesce("a");
}
