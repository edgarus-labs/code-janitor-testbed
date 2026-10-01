namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedIndexersDisabled;

public class EditorConfigCsharpStyleExpressionBodiedIndexersDisabled
{
    private int _value = 3;

    public int this[int index]
    {
        get { return _value + index; }
    }

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedIndexersDisabled()[1].ToString();
}
