namespace Testbed.EditorConfig.EditorConfigIDE0280NameofForAttributes;

using System.Diagnostics.CodeAnalysis;

public class EditorConfigIDE0280NameofForAttributes
{
    [return: NotNullIfNotNull("value")]
    private static string? Echo(string? value) => value;

    public static string Run() => Echo("ok") ?? "";
}
