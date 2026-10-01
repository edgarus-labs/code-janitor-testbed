namespace Testbed.CodeStyle.CsharpStylePatternMatchingOverAsWithNullCheck;

public class CsharpStylePatternMatchingOverAsWithNullCheck
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

    public static string Run() => new CsharpStylePatternMatchingOverAsWithNullCheck().AsCheck("abcd").ToString();
}
