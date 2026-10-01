namespace Testbed.EditorConfig.EditorConfigDotnetStyleParenthesesInOtherBinaryOperators;

public class EditorConfigDotnetStyleParenthesesInOtherBinaryOperators
{
    public bool Other(bool a, bool b, bool c)
    {
        return a && b || c;
    }

    public static string Run() => new EditorConfigDotnetStyleParenthesesInOtherBinaryOperators().Other(true, false, true).ToString();
}
