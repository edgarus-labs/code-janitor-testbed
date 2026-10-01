namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedMethodsWhenOnSingleLine;

public class EditorConfigCsharpStyleExpressionBodiedMethodsWhenOnSingleLine
{
    private int _value = 1;

    public int Short()
    {
        return _value + 1;
    }

    public int Long()
    {
        return _value
            + 2;
    }

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedMethodsWhenOnSingleLine().Short() + "," + new EditorConfigCsharpStyleExpressionBodiedMethodsWhenOnSingleLine().Long();
}
