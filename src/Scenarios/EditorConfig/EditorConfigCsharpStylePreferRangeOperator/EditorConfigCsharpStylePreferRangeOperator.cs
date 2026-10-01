namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferRangeOperator;

public class EditorConfigCsharpStylePreferRangeOperator
{
    public string Tail(string text)
    {
        return text.Substring(1);
    }

    public static string Run() => new EditorConfigCsharpStylePreferRangeOperator().Tail("abc");
}
