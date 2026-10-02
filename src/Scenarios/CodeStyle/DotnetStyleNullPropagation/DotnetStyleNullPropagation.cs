namespace Testbed.CodeStyle.DotnetStyleNullPropagation;

public class DotnetStyleNullPropagation
{
    public string? Upper(string? value)
    {
        return value == null ? null : value.ToUpperInvariant();
    }

    public static string Run() => new DotnetStyleNullPropagation().Upper("ab") ?? "none";
}
