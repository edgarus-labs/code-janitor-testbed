namespace Testbed.EditorConfig.EditorConfigDotnetStyleQualificationForPropertyTrue;

public class EditorConfigDotnetStyleQualificationForPropertyTrue
{
    private int Size { get; set; } = 2;

    public int Next() => Size + 1;

    public static string Run() => new EditorConfigDotnetStyleQualificationForPropertyTrue().Next().ToString();
}
