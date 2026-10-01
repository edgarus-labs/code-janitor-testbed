namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedMethods;

public class EditorConfigCsharpStyleExpressionBodiedMethods
{
    private int _value = 1;

    public int Method() => _value + 1;

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedMethods().Method().ToString();
}
