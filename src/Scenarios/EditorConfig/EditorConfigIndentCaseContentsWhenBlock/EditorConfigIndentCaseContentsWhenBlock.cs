namespace Testbed.EditorConfig.EditorConfigIndentCaseContentsWhenBlock;

using System.Linq;

public class EditorConfigIndentCaseContentsWhenBlock
{
    public static string Run()
    {
        var n = 1;
        switch (n)
        {
            case 1:
                {
                    n++;
                    break;
                }
            default:
                break;
        }

        return n.ToString();
    }
}
