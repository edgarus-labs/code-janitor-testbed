namespace Testbed.EditorConfig.EditorConfigCsharpStyleVarWhenTypeIsApparentFalseKeepsVar;

using System.Collections.Generic;

public class EditorConfigCsharpStyleVarWhenTypeIsApparentFalseKeepsVar
{
    public static string Run()
    {
        var list = new List<int>();
        var count = list.Count;

        return count.ToString();
    }
}
