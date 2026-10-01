namespace Testbed.EditorConfig.EditorConfigNewLineBeforeFinally;

using System.Linq;

public class EditorConfigNewLineBeforeFinally
{
    public static string Run()
    {
        var text = "a";
        try
        {
            text += "b";
        }
        finally
        {
            text += "c";
        }

        return text;
    }
}
