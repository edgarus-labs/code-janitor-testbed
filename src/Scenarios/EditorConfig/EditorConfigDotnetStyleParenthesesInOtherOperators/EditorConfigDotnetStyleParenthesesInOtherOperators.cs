namespace Testbed.EditorConfig.EditorConfigDotnetStyleParenthesesInOtherOperators;

public class EditorConfigDotnetStyleParenthesesInOtherOperators
{
    public int Unnecessary(int a, int b)
    {
        return ((a)) + (b);
    }

    public static string Run() => new EditorConfigDotnetStyleParenthesesInOtherOperators().Unnecessary(1, 2).ToString();
}
