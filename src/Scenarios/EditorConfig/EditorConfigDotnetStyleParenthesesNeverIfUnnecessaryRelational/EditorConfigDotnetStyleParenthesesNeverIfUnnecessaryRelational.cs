namespace Testbed.EditorConfig.EditorConfigDotnetStyleParenthesesNeverIfUnnecessaryRelational;

public class EditorConfigDotnetStyleParenthesesNeverIfUnnecessaryRelational
{
    public static string Run()
    {
        var a = 1;
        var b = 2;
        var c = 3;

        return ((a < b) == (b < c)).ToString();
    }
}
