namespace Testbed.CodeStyle.CsharpStylePreferNotPattern;

public class CsharpStylePreferNotPattern
{
    public bool NotString(object value)
    {
        return !(value is string);
    }

    public static string Run() => new CsharpStylePreferNotPattern().NotString(1).ToString();
}
