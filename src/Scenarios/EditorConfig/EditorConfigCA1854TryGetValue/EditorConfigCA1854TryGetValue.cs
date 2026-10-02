namespace Testbed.EditorConfig.EditorConfigCA1854TryGetValue;

using System.Collections.Generic;

public class EditorConfigCA1854TryGetValue
{
    private static string Find(Dictionary<int, string> map)
    {
        if (map.ContainsKey(1))
        {
            return map[1];
        }

        return "none";
    }

    public static string Run() => Find(new Dictionary<int, string> { [1] = "a" });
}
