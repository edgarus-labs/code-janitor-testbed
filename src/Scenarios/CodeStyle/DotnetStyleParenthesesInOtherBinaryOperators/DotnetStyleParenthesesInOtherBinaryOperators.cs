namespace Testbed.CodeStyle.DotnetStyleParenthesesInOtherBinaryOperators;

public class DotnetStyleParenthesesInOtherBinaryOperators
{
    public bool Other(bool a, bool b, bool c)
    {
        return a && b || c;
    }

    public static string Run() => new DotnetStyleParenthesesInOtherBinaryOperators().Other(true, false, true).ToString();
}
