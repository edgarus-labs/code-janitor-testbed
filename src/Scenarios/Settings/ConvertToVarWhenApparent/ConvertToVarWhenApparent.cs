namespace Testbed.Settings.ConvertToVarWhenApparent;

using System.Collections.Generic;

public class ConvertToVarWhenApparent
{
    public static string Run()
    {
        List<int> list = new List<int>();
        list.Add(1);
        Dictionary<string, int> map = new Dictionary<string, int>();

        return (list.Count + map.Count).ToString();
    }
}
