namespace Testbed.CodeStyle.CsharpStylePreferRangeOperator;

public class CsharpStylePreferRangeOperator
{
    public string Tail(string text)
    {
        return text.Substring(1);
    }

    public static string Run() => new CsharpStylePreferRangeOperator().Tail("abc");
}
