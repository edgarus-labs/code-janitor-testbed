namespace Testbed.EditorConfig.EditorConfigNewLineBeforeCatch;

using System.Linq;

public class EditorConfigNewLineBeforeCatch
{
    public static string Run()
    {
        try
        {
            return "a";
        }
        catch (System.Exception)
        {
            return "b";
        }
    }
}
