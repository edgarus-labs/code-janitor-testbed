namespace Testbed.EditorConfig.EditorConfigPreserveSingleLineStatements;

using System.Linq;

public class EditorConfigPreserveSingleLineStatements
{
    public static string Run()
    {
        var n = 1; n++; n++;

        return n.ToString();
    }
}
