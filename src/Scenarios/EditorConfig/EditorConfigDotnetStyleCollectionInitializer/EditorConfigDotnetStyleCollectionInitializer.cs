namespace Testbed.EditorConfig.EditorConfigDotnetStyleCollectionInitializer;

using System.Collections.Generic;

public class EditorConfigDotnetStyleCollectionInitializer
{
    public List<int> Collect()
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);

        return list;
    }

    public static string Run() => new EditorConfigDotnetStyleCollectionInitializer().Collect().Count.ToString();
}
