namespace Testbed.EditorConfig.EditorConfigPreferIsNullOverReferenceEquals;

public class EditorConfigPreferIsNullOverReferenceEquals
{
    public static bool Missing(string? text) => ReferenceEquals(text, null);

    public static string Run() => Missing(null).ToString();
}
