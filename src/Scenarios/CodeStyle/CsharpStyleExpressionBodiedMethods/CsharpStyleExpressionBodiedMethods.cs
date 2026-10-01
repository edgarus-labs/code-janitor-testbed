namespace Testbed.CodeStyle.CsharpStyleExpressionBodiedMethods;

public class CsharpStyleExpressionBodiedMethods
{
    private int _value = 1;

    public int Method() => _value + 1;

    public static string Run() => new CsharpStyleExpressionBodiedMethods().Method().ToString();
}
