namespace Testbed.EditorConfig.EditorConfigSpaceBetweenMethodDeclarationNameAndOpenParenthesis;

using System.Linq;

public class EditorConfigSpaceBetweenMethodDeclarationNameAndOpenParenthesis
{
    public static string Run()
    {
        return Add(1, 2).ToString();
    }

    private static int Add(int a, int b) => a + b;
}
