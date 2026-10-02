namespace Testbed.EditorConfig.EditorConfigExpressionBodiedLambdas;

public class EditorConfigExpressionBodiedLambdas
{
    public static string Run()
    {
        System.Func<int, int> twice = x => { return x * 2; };

        return twice(4).ToString();
    }
}
