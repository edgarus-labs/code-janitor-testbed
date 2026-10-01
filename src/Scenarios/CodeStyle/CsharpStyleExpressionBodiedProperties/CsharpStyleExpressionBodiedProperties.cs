namespace Testbed.CodeStyle.CsharpStyleExpressionBodiedProperties;

public class CsharpStyleExpressionBodiedProperties
{
    private int _value = 3;

    public int Property
    {
        get { return _value; }
    }

    public static string Run() => new CsharpStyleExpressionBodiedProperties().Property.ToString();
}
