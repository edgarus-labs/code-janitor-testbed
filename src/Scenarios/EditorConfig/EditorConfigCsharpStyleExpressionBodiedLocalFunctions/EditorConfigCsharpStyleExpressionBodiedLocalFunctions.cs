namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedLocalFunctions;

public class EditorConfigCsharpStyleExpressionBodiedLocalFunctions
{
    public int Twice(int value)
    {
        int Local(int x) => x * 2;

        return Local(value);
    }

    public static string Run() => new EditorConfigCsharpStyleExpressionBodiedLocalFunctions().Twice(4).ToString();
}
