namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferPatternMatching;

public class EditorConfigCsharpStylePreferPatternMatching
{
    public bool InRange(int value)
    {
        return value == 1 || value == 2 || value == 3;
    }

    public static string Run() => new EditorConfigCsharpStylePreferPatternMatching().InRange(2).ToString();
}
