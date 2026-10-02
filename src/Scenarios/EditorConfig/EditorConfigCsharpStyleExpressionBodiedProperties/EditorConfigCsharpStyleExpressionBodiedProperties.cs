namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedProperties;

public class EditorConfigCsharpStyleExpressionBodiedProperties
{
    private int _value = 3;

    public int Property
    {
        get { return _value; }
    }

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedProperties().Property.ToString();
}
