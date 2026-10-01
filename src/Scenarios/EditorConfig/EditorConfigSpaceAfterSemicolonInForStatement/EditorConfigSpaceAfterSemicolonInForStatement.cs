namespace Testbed.EditorConfig.EditorConfigSpaceAfterSemicolonInForStatement;

using System.Linq;

public class EditorConfigSpaceAfterSemicolonInForStatement
{
    public static string Run()
    {
        var n = 0;
        for (var i = 0; i < 3; i++)
        {
            n += i;
        }

        return n.ToString();
    }
}
