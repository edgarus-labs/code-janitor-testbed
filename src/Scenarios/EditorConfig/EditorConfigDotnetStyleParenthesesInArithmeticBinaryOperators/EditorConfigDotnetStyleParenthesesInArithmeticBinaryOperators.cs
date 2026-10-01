namespace Testbed.EditorConfig.EditorConfigDotnetStyleParenthesesInArithmeticBinaryOperators;

public class EditorConfigDotnetStyleParenthesesInArithmeticBinaryOperators
{
    public int Arithmetic(int a, int b, int c)
    {
        return a + b * c;
    }

    public static string Run() => new EditorConfigDotnetStyleParenthesesInArithmeticBinaryOperators().Arithmetic(1, 2, 3).ToString();
}
