namespace Testbed.EditorConfig.EditorConfigSpaceBetweenMethodCallEmptyParameterListParentheses;

using System.Linq;

public class EditorConfigSpaceBetweenMethodCallEmptyParameterListParentheses
{
    public static string Run()
    {
        var n = Make();

        return n.ToString();
    }

    private static int Make() => 1;
}
