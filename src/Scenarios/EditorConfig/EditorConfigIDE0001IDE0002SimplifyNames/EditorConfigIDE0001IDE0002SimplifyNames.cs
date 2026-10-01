namespace Testbed.EditorConfig.EditorConfigIDE0001IDE0002SimplifyNames;

using System.IO;

public class EditorConfigIDE0001IDE0002SimplifyNames
{
    private static int Helper() => 1;

    public static string Run()
    {
        System.IO.FileInfo info = new System.IO.FileInfo("x.txt");

        return EditorConfigIDE0001IDE0002SimplifyNames.Helper() + info.Name;
    }
}
