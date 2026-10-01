namespace Testbed.EditorConfig.EditorConfigDotnetStyleQualificationForFieldTrue;

public class EditorConfigDotnetStyleQualificationForFieldTrue
{
    private int _count = 1;

    public int Next() => _count + 1;

    public static string Run() => new EditorConfigDotnetStyleQualificationForFieldTrue().Next().ToString();
}
