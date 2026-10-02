namespace Testbed.EditorConfig.EditorConfigCA1829CA1860LengthInsteadOfCount;

using System.Linq;

public class EditorConfigCA1829CA1860LengthInsteadOfCount
{
    public static string Run()
    {
        int[] items = { 1, 2, 3 };
        var count = items.Count();
        var any = items.Any();

        return count + "," + any;
    }
}
