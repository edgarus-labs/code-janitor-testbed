namespace Testbed.CodeStyle.DotnetStyleParenthesesInRelationalBinaryOperators;

public class DotnetStyleParenthesesInRelationalBinaryOperators
{
    public bool Relational(int a, int b, int c)
    {
        return a < b == (b < c);
    }

    public static string Run() => new DotnetStyleParenthesesInRelationalBinaryOperators().Relational(1, 2, 3).ToString();
}
