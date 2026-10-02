namespace Testbed.EditorConfig.EditorConfigDotnetStyleParenthesesNeverIfUnnecessaryOtherBinary;

public class EditorConfigDotnetStyleParenthesesNeverIfUnnecessaryOtherBinary
{
    public static string Run()
    {
        var a = true;
        var b = false;
        var c = true;

        return ((a && b) || c).ToString();
    }
}
