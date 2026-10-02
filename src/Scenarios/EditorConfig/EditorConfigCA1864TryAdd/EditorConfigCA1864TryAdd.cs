namespace Testbed.EditorConfig.EditorConfigCA1864TryAdd;

using System.Collections.Generic;

public class EditorConfigCA1864TryAdd
{
    public static string Run()
    {
        var map = new Dictionary<int, string>();
        if (!map.ContainsKey(2))
        {
            map.Add(2, "b");
        }

        return map.Count.ToString();
    }
}
