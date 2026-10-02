namespace Testbed.CodeStyle.CsharpStyleExpressionBodiedAccessors;

public class CsharpStyleExpressionBodiedAccessors
{
    private int _value;

    public int Accessors
    {
        get { return _value; }
        set { _value = value; }
    }

    public static string Run()
    {
        var instance = new CsharpStyleExpressionBodiedAccessors();
        instance.Accessors = 4;

        return instance.Accessors.ToString();
    }
}
