namespace Testbed.CodeStyle.DotnetStyleParenthesesInOtherOperators;

public class DotnetStyleParenthesesInOtherOperators
{
    public int Unnecessary(int a, int b)
    {
        return ((a)) + (b);
    }

    public static string Run() => new DotnetStyleParenthesesInOtherOperators().Unnecessary(1, 2).ToString();
}
