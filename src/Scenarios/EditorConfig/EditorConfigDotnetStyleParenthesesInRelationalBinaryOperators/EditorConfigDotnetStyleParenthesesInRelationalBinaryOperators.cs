namespace Testbed.EditorConfig.EditorConfigDotnetStyleParenthesesInRelationalBinaryOperators;

public class EditorConfigDotnetStyleParenthesesInRelationalBinaryOperators
{
    public bool Relational(int a, int b, int c)
    {
        return a < b == (b < c);
    }

    public static string Run() => new EditorConfigDotnetStyleParenthesesInRelationalBinaryOperators().Relational(1, 2, 3).ToString();
}
