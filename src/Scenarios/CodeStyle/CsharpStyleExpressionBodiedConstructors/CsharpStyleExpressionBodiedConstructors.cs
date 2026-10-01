namespace Testbed.CodeStyle.CsharpStyleExpressionBodiedConstructors;

public class CsharpStyleExpressionBodiedConstructors
{
    private int _value;

    public CsharpStyleExpressionBodiedConstructors() => _value = 1;

    public static string Run() => new CsharpStyleExpressionBodiedConstructors()._value.ToString();
}
