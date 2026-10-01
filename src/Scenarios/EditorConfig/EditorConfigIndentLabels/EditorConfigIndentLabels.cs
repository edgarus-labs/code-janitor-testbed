namespace Testbed.EditorConfig.EditorConfigIndentLabels;

using System.Linq;

public class EditorConfigIndentLabels
{
    public static string Run()
    {
        var n = 0;
        again:
        n++;
        if (n < 3)
        {
            goto again;
        }

        return n.ToString();
    }
}
