namespace Testbed.EditorConfig.EditorConfigNewLineBeforeElse;

using System.Linq;

public class EditorConfigNewLineBeforeElse
{
    public static string Run()
    {
        var n = 1;
        if (n > 0)
        {
            n++;
        }
        else
        {
            n--;
        }

        return n.ToString();
    }
}
