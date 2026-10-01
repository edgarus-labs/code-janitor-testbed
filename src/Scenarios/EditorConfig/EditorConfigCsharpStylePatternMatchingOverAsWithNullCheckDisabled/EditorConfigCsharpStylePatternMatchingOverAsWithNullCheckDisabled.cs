namespace Testbed.EditorConfig.EditorConfigCsharpStylePatternMatchingOverAsWithNullCheckDisabled;

public class EditorConfigCsharpStylePatternMatchingOverAsWithNullCheckDisabled
{
    public int AsCheck(object value)
    {
        var text = value as string;
        if (text != null)
        {
            return text.Length;
        }

        return 0;
    }

    public static string Run() => new EditorConfigCsharpStylePatternMatchingOverAsWithNullCheckDisabled().AsCheck("abcd").ToString();
}
