namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedAccessors;

public class EditorConfigCsharpStyleExpressionBodiedAccessors
{
    private int _value;

    public int Accessors
    {
        get { return _value; }
        set { _value = value; }
    }

    public static string Run()
    {
        var instance = new EditorConfigCsharpStyleExpressionBodiedAccessors();
        instance.Accessors = 4;

        return instance.Accessors.ToString();
    }
}
