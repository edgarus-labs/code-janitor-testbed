namespace Testbed.EditorConfig.EditorConfigDotnetStyleCollectionInitializerDisabled;

using System.Collections.Generic;

public class EditorConfigDotnetStyleCollectionInitializerDisabled
{
    public List<int> Collect()
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);

        return list;
    }

    public static string Run() => new EditorConfigDotnetStyleCollectionInitializerDisabled().Collect().Count.ToString();
}
