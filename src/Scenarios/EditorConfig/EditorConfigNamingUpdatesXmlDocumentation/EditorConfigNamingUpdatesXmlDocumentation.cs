namespace Testbed.EditorConfig.EditorConfigNamingUpdatesXmlDocumentation;

public class EditorConfigNamingUpdatesXmlDocumentation
{
    /// <summary>Doubles <paramref name="Value"/>.</summary>
    /// <param name="Value">The value.</param>
    private static int Double(int Value) => Value * 2;

    public static string Run() => Double(2).ToString();
}
