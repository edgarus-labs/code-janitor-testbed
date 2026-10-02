namespace Testbed.EditorConfig.EditorConfigSpaceBetweenParentheses;

using System.Linq;

public class EditorConfigSpaceBetweenParentheses
{
    public static string Run()
    {
        var n = (1 + 2) * 3;

        return n.ToString();
    }
}
