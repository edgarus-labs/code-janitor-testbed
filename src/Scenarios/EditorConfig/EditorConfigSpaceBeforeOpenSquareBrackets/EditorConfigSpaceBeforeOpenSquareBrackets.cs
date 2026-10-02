namespace Testbed.EditorConfig.EditorConfigSpaceBeforeOpenSquareBrackets;

using System.Linq;

public class EditorConfigSpaceBeforeOpenSquareBrackets
{
    public static string Run()
    {
        var values = new[] { 1, 2 };

        return values[1].ToString();
    }
}
