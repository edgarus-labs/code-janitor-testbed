namespace Testbed.CodeStyle.DotnetStyleParenthesesInArithmeticBinaryOperators;

public class DotnetStyleParenthesesInArithmeticBinaryOperators
{
    public int Arithmetic(int a, int b, int c)
    {
        return a + b * c;
    }

    public static string Run() => new DotnetStyleParenthesesInArithmeticBinaryOperators().Arithmetic(1, 2, 3).ToString();
}
