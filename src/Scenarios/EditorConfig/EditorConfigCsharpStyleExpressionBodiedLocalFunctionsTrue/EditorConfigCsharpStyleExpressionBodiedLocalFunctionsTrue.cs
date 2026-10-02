namespace Testbed.EditorConfig.EditorConfigCsharpStyleExpressionBodiedLocalFunctionsTrue;

public class EditorConfigCsharpStyleExpressionBodiedLocalFunctionsTrue
{
    public static string Run()
    {
        int Local(int x)
        {
            return x * 2;
        }

        return Local(4).ToString();
    }
}
