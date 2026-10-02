namespace Testbed.EditorConfig.EditorConfigPreserveSingleLineBlocks;

using System.Linq;

public class EditorConfigPreserveSingleLineBlocks
{
    public static string Run()
    {
        var n = 1;
        if (n > 0) { n++; }

        return n.ToString();
    }
}
