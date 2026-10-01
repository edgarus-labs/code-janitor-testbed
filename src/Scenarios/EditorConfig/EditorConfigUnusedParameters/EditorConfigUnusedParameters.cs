namespace Testbed.EditorConfig.EditorConfigUnusedParameters;

public class EditorConfigUnusedParameters
{
    private static int Echo(int used, int unused) => used;

    public static string Run() => Echo(1, 2).ToString();
}
