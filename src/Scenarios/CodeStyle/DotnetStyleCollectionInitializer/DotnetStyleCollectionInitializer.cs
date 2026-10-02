namespace Testbed.CodeStyle.DotnetStyleCollectionInitializer;

using System.Collections.Generic;

public class DotnetStyleCollectionInitializer
{
    public List<int> Collect()
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);

        return list;
    }

    public static string Run() => new DotnetStyleCollectionInitializer().Collect().Count.ToString();
}
