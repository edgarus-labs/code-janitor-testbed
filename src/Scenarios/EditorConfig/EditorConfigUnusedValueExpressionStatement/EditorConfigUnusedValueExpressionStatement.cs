namespace Testbed.EditorConfig.EditorConfigUnusedValueExpressionStatement;

public class EditorConfigUnusedValueExpressionStatement
{
    private static int Compute() => 42;

    public static string Run()
    {
        Compute();

        return "ok";
    }
}
