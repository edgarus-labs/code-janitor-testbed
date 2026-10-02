namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedMethodsTrue;

public class EditorConfigCsharpStyleExpressionBodiedMethodsTrue
{
    private int _value = 1;

    public int Method()
    {
        return _value + 1;
    }

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedMethodsTrue().Method().ToString();
}
