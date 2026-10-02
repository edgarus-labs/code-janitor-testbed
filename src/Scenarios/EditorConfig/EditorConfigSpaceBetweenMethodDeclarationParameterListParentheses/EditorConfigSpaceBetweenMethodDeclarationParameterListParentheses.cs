namespace Testbed.EditorConfig.EditorConfigSpaceBetweenMethodDeclarationParameterListParentheses;

using System.Linq;

public class EditorConfigSpaceBetweenMethodDeclarationParameterListParentheses
{
    public static string Run()
    {
        return Add(1, 2).ToString();
    }

    private static int Add(int a, int b) => a + b;
}
