namespace Testbed.EditorConfig.EditorConfigIndentSwitchLabels;

using System.Linq;

public class EditorConfigIndentSwitchLabels
{
    public static string Run()
    {
        var n = 1;
        switch (n)
        {
            case 1:
                n++;
                break;
            default:
                break;
        }

        return n.ToString();
    }
}
