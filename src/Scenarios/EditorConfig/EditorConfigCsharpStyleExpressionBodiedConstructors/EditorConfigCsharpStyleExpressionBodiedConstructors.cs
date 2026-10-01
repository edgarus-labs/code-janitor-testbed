namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedConstructors;

public class EditorConfigCsharpStyleExpressionBodiedConstructors
{
    private int _value;

    public EditorConfigCsharpStyleExpressionBodiedConstructors() => _value = 1;

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedConstructors()._value.ToString();
}
