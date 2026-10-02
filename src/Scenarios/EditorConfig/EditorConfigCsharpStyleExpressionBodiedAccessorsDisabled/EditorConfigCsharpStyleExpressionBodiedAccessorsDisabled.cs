namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedAccessorsDisabled;

public class EditorConfigCsharpStyleExpressionBodiedAccessorsDisabled
{
    private int _value;

    public int Accessors
    {
        get { return _value; }
        set { _value = value; }
    }

    public static string Run()
    {
        var instance = new EditorConfigCsharpStyleExpressionBodiedAccessorsDisabled();
        instance.Accessors = 4;

        return instance.Accessors.ToString();
    }
}
