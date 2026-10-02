namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferRangeOperatorDisabled;

public class EditorConfigCsharpStylePreferRangeOperatorDisabled
{
    public string Tail(string text)
    {
        return text.Substring(1);
    }

    public static string Run() => new EditorConfigCsharpStylePreferRangeOperatorDisabled().Tail("abc");
}
