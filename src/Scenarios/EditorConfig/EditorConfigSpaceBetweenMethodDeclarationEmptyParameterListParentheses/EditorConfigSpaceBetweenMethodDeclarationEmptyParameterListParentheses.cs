namespace Testbed.EditorConfig.EditorConfigSpaceBetweenMethodDeclarationEmptyParameterListParentheses;

using System.Linq;

public class EditorConfigSpaceBetweenMethodDeclarationEmptyParameterListParentheses
{
    public static string Run()
    {
        return Make().ToString();
    }

    private static int Make() => 1;
}
