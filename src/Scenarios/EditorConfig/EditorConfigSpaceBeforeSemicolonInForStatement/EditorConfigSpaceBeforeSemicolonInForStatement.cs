namespace Testbed.EditorConfig.EditorConfigSpaceBeforeSemicolonInForStatement;

using System.Linq;

public class EditorConfigSpaceBeforeSemicolonInForStatement
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
