namespace Testbed.CodeStyle.CsharpStyleExpressionBodiedIndexers;

public class CsharpStyleExpressionBodiedIndexers
{
    private int _value = 3;

    public int this[int index]
    {
        get { return _value + index; }
    }

    public static string Run() => new CsharpStyleExpressionBodiedIndexers()[1].ToString();
}
