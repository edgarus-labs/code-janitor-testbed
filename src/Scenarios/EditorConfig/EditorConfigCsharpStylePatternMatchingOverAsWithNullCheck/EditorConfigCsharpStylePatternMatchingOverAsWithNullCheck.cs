namespace Testbed.EditorConfig.EditorConfigCsharpStylePatternMatchingOverAsWithNullCheck;

public class EditorConfigCsharpStylePatternMatchingOverAsWithNullCheck
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

    public static string Run() => new EditorConfigCsharpStylePatternMatchingOverAsWithNullCheck().AsCheck("abcd").ToString();
}
