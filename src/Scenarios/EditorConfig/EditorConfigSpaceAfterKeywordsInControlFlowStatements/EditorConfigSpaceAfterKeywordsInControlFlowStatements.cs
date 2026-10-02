namespace Testbed.EditorConfig.EditorConfigSpaceAfterKeywordsInControlFlowStatements;

using System.Linq;

public class EditorConfigSpaceAfterKeywordsInControlFlowStatements
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
