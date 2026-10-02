namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedConstructorsTrue;

public class EditorConfigCsharpStyleExpressionBodiedConstructorsTrue
{
    private int _value;

    public EditorConfigCsharpStyleExpressionBodiedConstructorsTrue()
    {
        _value = 1;
    }

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedConstructorsTrue()._value.ToString();
}
