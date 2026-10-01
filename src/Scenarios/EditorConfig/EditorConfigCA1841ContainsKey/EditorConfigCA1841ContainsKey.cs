namespace Testbed.EditorConfig.EditorConfigCA1841ContainsKey;

using System.Collections.Generic;
using System.Linq;

public class EditorConfigCA1841ContainsKey
{
    public static string Run()
    {
        var map = new Dictionary<int, string> { [1] = "a" };

        return map.Keys.Contains(1).ToString();
    }
}
