namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedPropertiesDisabled;

public class EditorConfigCsharpStyleExpressionBodiedPropertiesDisabled
{
    private int _value = 3;

    public int Property
    {
        get { return _value; }
    }

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedPropertiesDisabled().Property.ToString();
}
