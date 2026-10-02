namespace Testbed.EditorConfig.EditorConfigDotnetStyleQualificationForMethodTrue;

public class EditorConfigDotnetStyleQualificationForMethodTrue
{
    private int Twice(int value) => value * 2;

    public int Next() => Twice(2);

    public static string Run() => new EditorConfigDotnetStyleQualificationForMethodTrue().Next().ToString();
}
