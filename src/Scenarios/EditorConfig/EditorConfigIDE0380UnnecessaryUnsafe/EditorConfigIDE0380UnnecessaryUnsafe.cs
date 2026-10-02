namespace Testbed.EditorConfig.EditorConfigIDE0380UnnecessaryUnsafe;

public class EditorConfigIDE0380UnnecessaryUnsafe
{
    private static unsafe int Plain() => 1;

    public static string Run() => Plain().ToString();
}
