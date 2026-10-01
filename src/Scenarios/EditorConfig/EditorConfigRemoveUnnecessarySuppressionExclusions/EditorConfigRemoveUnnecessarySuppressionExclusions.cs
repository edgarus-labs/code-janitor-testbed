namespace Testbed.EditorConfig.EditorConfigRemoveUnnecessarySuppressionExclusions;

public class EditorConfigRemoveUnnecessarySuppressionExclusions
{
#pragma warning disable IDE0001
    private static System.IO.FileInfo Info() => new System.IO.FileInfo("x");
#pragma warning restore IDE0001

    public static string Run() => Info().Name;
}
