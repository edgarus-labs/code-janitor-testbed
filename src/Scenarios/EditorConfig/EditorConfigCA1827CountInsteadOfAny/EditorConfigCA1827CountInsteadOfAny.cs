namespace Testbed.EditorConfig.EditorConfigCA1827CountInsteadOfAny;

using System.Linq;

public class EditorConfigCA1827CountInsteadOfAny
{
    public static string Run()
    {
        System.Collections.Generic.IEnumerable<int> items = new[] { 1, 2 };
        var none = items.Count() == 0;
        var some = items.Count() > 0;

        return none + "," + some;
    }
}
