namespace Testbed.EditorConfig.EditorConfigDotnetStyleParenthesesNeverIfUnnecessaryArithmetic;

public class EditorConfigDotnetStyleParenthesesNeverIfUnnecessaryArithmetic
{
    public static string Run()
    {
        var a = 1;
        var b = 2;
        var c = 3;

        return (a + (b * c)).ToString();
    }
}
