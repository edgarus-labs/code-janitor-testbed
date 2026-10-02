namespace Testbed.EditorConfig.EditorConfigCsharpStylePreferPatternMatchingDisabled;

public class EditorConfigCsharpStylePreferPatternMatchingDisabled
{
    public bool InRange(int value)
    {
        return value == 1 || value == 2 || value == 3;
    }

    public static string Run() => new EditorConfigCsharpStylePreferPatternMatchingDisabled().InRange(2).ToString();
}
