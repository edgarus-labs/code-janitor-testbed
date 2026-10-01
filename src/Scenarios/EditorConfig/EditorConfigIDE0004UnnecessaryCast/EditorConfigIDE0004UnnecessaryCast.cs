namespace Testbed.EditorConfig.EditorConfigIDE0004UnnecessaryCast;

public class EditorConfigIDE0004UnnecessaryCast
{
    public static string Run()
    {
        int a = 1;
        int b = (int)a;

        return b.ToString();
    }
}
