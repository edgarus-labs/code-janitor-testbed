namespace Testbed.EditorConfig.EditorConfigCA1868SetAdd;

using System.Collections.Generic;

public class EditorConfigCA1868SetAdd
{
    public static string Run()
    {
        var set = new HashSet<int>();
        if (!set.Contains(3))
        {
            set.Add(3);
        }

        return set.Count.ToString();
    }
}
