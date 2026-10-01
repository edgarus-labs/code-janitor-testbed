namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedIndexers;

public class EditorConfigCsharpStyleExpressionBodiedIndexers
{
    private int _value = 3;

    public int this[int index]
    {
        get { return _value + index; }
    }

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedIndexers()[1].ToString();
}
